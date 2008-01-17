
/*
* Copyright (c) 2007 SlimDX Group
* 
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
*/
#include <windows.h>
#include <d3d9.h>
#include <d3dx9.h>
#include <vcclr.h>
#include <memory>

#include "../BaseObject.h"
#include "../Utilities.h"

#include "Effect.h"
#include "../Direct3D/..\DataStream.h"
#include "ConstantTable.h"
#include "Device.h"

namespace SlimDX
{
namespace Direct3D9
{
	void ConstantDescription::Initialize( const D3DXCONSTANT_DESC& desc )
	{
		Name = gcnew String( desc.Name );
		RegisterSet = static_cast<SlimDX::Direct3D9::RegisterSet>( desc.RegisterSet );
		RegisterIndex = desc.RegisterIndex;
		RegisterCount = desc.RegisterCount;
		Class = static_cast<ParameterClass>( desc.Class );
		Type = static_cast<ParameterType>( desc.Type );
		Rows = desc.Rows;
		Columns = desc.Columns;
		Elements = desc.Elements;
		StructMembers = desc.StructMembers;
		Bytes = desc.Bytes;
	}

	ConstantTable::ConstantTable( ID3DXConstantTable* table )
	{
		Construct(table);
	}

	ConstantTable::ConstantTable( IntPtr table )
	{
		Construct( table, IID_ID3DXConstantTable );
	}

	ConstantTable::ConstantTable( IDirect3DDevice9* device,ID3DXConstantTable* constantTable )
		: m_Device(device)
	{
		Construct(constantTable);

		m_Device->AddRef();
	}

	ConstantTable::~ConstantTable()
	{
		Destruct();
		m_Device->Release();
	}
	
	EffectHandle^ ConstantTable::GetConstant(SlimDX::Direct3D9::EffectHandle ^handle, int index)
	{
		D3DXHANDLE parentHandle = handle != nullptr ? handle->InternalHandle : NULL;
		D3DXHANDLE result = InternalPointer->GetConstant( parentHandle, index );
		
		if( result == NULL )
			return nullptr;
		return gcnew EffectHandle( result );
	}
	
	EffectHandle^ ConstantTable::GetConstant(SlimDX::Direct3D9::EffectHandle ^handle, String^ name )
	{
		array<unsigned char>^ rawName = System::Text::ASCIIEncoding::ASCII->GetBytes( name );
		pin_ptr<unsigned char> pinnedName = &rawName[0];
		
		D3DXHANDLE parentHandle = handle != nullptr ? handle->InternalHandle : NULL;
		D3DXHANDLE result = InternalPointer->GetConstantByName( parentHandle, reinterpret_cast<const char*>( pinnedName ) );
		
		if( result == NULL )
			return nullptr;
		return gcnew EffectHandle( result );
	}
	
	EffectHandle^ ConstantTable::GetConstantElement( EffectHandle^ handle, int index )
	{
		D3DXHANDLE parentHandle = handle != nullptr ? handle->InternalHandle : NULL;
		D3DXHANDLE result = InternalPointer->GetConstantElement( parentHandle, index );
		
		if( result == NULL )
			return nullptr;
		return gcnew EffectHandle( result );
	}

	ConstantDescription ConstantTable::GetConstantDescription( EffectHandle^ handle )
	{
		D3DXCONSTANT_DESC nativeDesc;
		ConstantDescription desc;

		D3DXHANDLE nativeHandle = handle != nullptr ? handle->InternalHandle : NULL;
		unsigned int count = 1;

		HRESULT hr = InternalPointer->GetConstantDesc( nativeHandle, &nativeDesc, &count );
		GraphicsException::CheckHResult( hr );
		if( FAILED( hr ) )
			return desc;

		desc.Initialize( nativeDesc );
		return desc;
	}

	array<ConstantDescription>^ ConstantTable::GetConstantDescriptionArray( EffectHandle^ handle )
	{
		//TODO: Check that the logic here is actually correct. The SDK doesn't bother to explain.
		D3DXHANDLE nativeHandle = handle != nullptr ? handle->InternalHandle : NULL;
		unsigned int count = 0;

		//Determine the count
		HRESULT hr = InternalPointer->GetConstantDesc( nativeHandle, NULL, &count );
		GraphicsException::CheckHResult( hr );
		if( FAILED( hr ) )
			return nullptr;

		//Get the actual data
		std::auto_ptr<D3DXCONSTANT_DESC> nativeDescArray(new D3DXCONSTANT_DESC[count]);
		hr = InternalPointer->GetConstantDesc( nativeHandle, nativeDescArray.get(), &count );
		GraphicsException::CheckHResult( hr );
		if( FAILED( hr ) )
			return nullptr;

		//Marshal the data
		array<ConstantDescription>^ descArray = gcnew array<ConstantDescription>( count );
		for( unsigned int i = 0; i < count; ++i )
		{
			const D3DXCONSTANT_DESC* nativeDesc = nativeDescArray.get() + i;
			descArray[i].Initialize( *nativeDesc );
		}

		return descArray;
	}

	int ConstantTable::GetSamplerIndex( EffectHandle^ sampler )
	{
		D3DXHANDLE handle = sampler != nullptr ? sampler->InternalHandle : NULL;
		int result = InternalPointer->GetSamplerIndex( handle );
		return result;
	}

	DataStream^ ConstantTable::GetBuffer()
	{
		DWORD size = InternalPointer->GetBufferSize();
		void* pointer = InternalPointer->GetBufferPointer();
		if( pointer == NULL )
			return nullptr;

		return gcnew DataStream( pointer, size, true, true, false );
	}

	void ConstantTable::SetDefaults()
	{
		HRESULT hr = InternalPointer->SetDefaults( m_Device );
		GraphicsException::CheckHResult( hr );
	}

	void ConstantTable::SetValue( EffectHandle^ constant, bool value )
	{
		D3DXHANDLE handle = constant != nullptr ? constant->InternalHandle : NULL;
		HRESULT hr = InternalPointer->SetBool( m_Device, handle, value );
		GraphicsException::CheckHResult( hr );
	}

	void ConstantTable::SetValue( EffectHandle^ param, array<bool>^ values )
	{
		//implementing set for bool array is REALLY ANNOYING.
		//Win32 uses BOOL, which is an int
		array<BOOL>^ expandedArray = gcnew array<BOOL>( values->Length );
		Array::Copy( values, expandedArray, values->Length );

		D3DXHANDLE handle = param != nullptr ? param->InternalHandle : NULL;
		pin_ptr<BOOL> pinnedValue = &expandedArray[0];
		HRESULT hr = InternalPointer->SetBoolArray( m_Device, handle, pinnedValue, values->Length );
		GraphicsException::CheckHResult( hr );
	}

	void ConstantTable::SetValue( EffectHandle^ constant, int value )
	{
		D3DXHANDLE handle = constant != nullptr ? constant->InternalHandle : NULL;
		HRESULT hr = InternalPointer->SetInt( m_Device, handle, value );
		GraphicsException::CheckHResult( hr );
	}

	void ConstantTable::SetValue( EffectHandle^ constant, array<int>^ values )
	{
		D3DXHANDLE handle = constant != nullptr ? constant->InternalHandle : NULL;
		pin_ptr<int> pinned_value = &values[0];
		HRESULT hr = InternalPointer->SetIntArray( m_Device, handle, pinned_value, values->Length );
		GraphicsException::CheckHResult( hr );
	}

	void ConstantTable::SetValue( EffectHandle^ constant, float value )
	{
		D3DXHANDLE handle = constant != nullptr ? constant->InternalHandle : NULL;
		HRESULT hr = InternalPointer->SetFloat( m_Device, handle, value );
		GraphicsException::CheckHResult( hr );
	}

	void ConstantTable::SetValue( EffectHandle^ constant, array<float>^ values )
	{
		D3DXHANDLE handle = constant != nullptr ? constant->InternalHandle : NULL;
		pin_ptr<float> pinned_values = &values[0];
		HRESULT hr = InternalPointer->SetFloatArray( m_Device, handle, pinned_values, values->Length );
		GraphicsException::CheckHResult( hr );
	}

	void ConstantTable::SetValue( EffectHandle^ constant, Vector4 value )
	{
		D3DXHANDLE handle = constant != nullptr ? constant->InternalHandle : NULL;
		HRESULT hr = InternalPointer->SetVector( m_Device, handle, reinterpret_cast<const D3DXVECTOR4*>( &value ) );
		GraphicsException::CheckHResult( hr );
	}

	void ConstantTable::SetValue( EffectHandle^ constant, array<Vector4>^ values )
	{
		D3DXHANDLE handle = constant != nullptr ? constant->InternalHandle : NULL;
		pin_ptr<Vector4> pinned_value = &values[0];
		HRESULT hr = InternalPointer->SetVectorArray( m_Device, handle, reinterpret_cast<const D3DXVECTOR4*>( pinned_value ), values->Length );
		GraphicsException::CheckHResult( hr );
	}

	void ConstantTable::SetValue( EffectHandle^ constant, ColorValue value )
	{
		D3DXHANDLE handle = constant != nullptr ? constant->InternalHandle : NULL;
		HRESULT hr = InternalPointer->SetVector( m_Device, handle, reinterpret_cast<const D3DXVECTOR4*>( &value ) );
		GraphicsException::CheckHResult( hr );
	}

	void ConstantTable::SetValue( EffectHandle^ constant, array<ColorValue>^ values )
	{
		D3DXHANDLE handle = constant != nullptr ? constant->InternalHandle : NULL;
		pin_ptr<ColorValue> pinned_value = &values[0];
		HRESULT hr = InternalPointer->SetVectorArray( m_Device, handle, reinterpret_cast<const D3DXVECTOR4*>( pinned_value ), values->Length );
		GraphicsException::CheckHResult( hr );
	}

	void ConstantTable::SetValue( EffectHandle^ constant, Matrix value )
	{
		D3DXHANDLE handle = constant != nullptr ? constant->InternalHandle : NULL;
		HRESULT hr = InternalPointer->SetMatrix( m_Device, handle, reinterpret_cast<const D3DXMATRIX*>( &value ) );
		GraphicsException::CheckHResult( hr );
	}

	void ConstantTable::SetValue( EffectHandle^ constant, array<Matrix>^ values )
	{
		D3DXHANDLE handle = constant != nullptr ? constant->InternalHandle : NULL;
		pin_ptr<Matrix> pinned_value = &values[0];
		HRESULT hr = InternalPointer->SetMatrixArray( m_Device, handle, reinterpret_cast<const D3DXMATRIX*>( pinned_value ), values->Length );
		GraphicsException::CheckHResult( hr );
	}

	void ConstantTable::SetValueTranspose( EffectHandle^ constant, Matrix value )
	{
		D3DXHANDLE handle = constant != nullptr ? constant->InternalHandle : NULL;
		HRESULT hr = InternalPointer->SetMatrixTranspose( m_Device, handle, reinterpret_cast<const D3DXMATRIX*>( &value ) );
		GraphicsException::CheckHResult( hr );
	}

	void ConstantTable::SetValueTranspose( EffectHandle^ constant, array<Matrix>^ values )
	{
		D3DXHANDLE handle = constant != nullptr ? constant->InternalHandle : NULL;
		pin_ptr<Matrix> pinned_value = &values[0];
		HRESULT hr = InternalPointer->SetMatrixTransposeArray( m_Device, handle, reinterpret_cast<const D3DXMATRIX*>( pinned_value ), values->Length );
		GraphicsException::CheckHResult( hr );
	}

	ConstantTableDescription ConstantTable::Description::get()
	{
		D3DXCONSTANTTABLE_DESC nativeDesc;
		ConstantTableDescription desc;

		HRESULT hr = InternalPointer->GetDesc( &nativeDesc );
		GraphicsException::CheckHResult( hr );
		if( FAILED( hr ) )
			return desc;

		desc.Creator = gcnew String( nativeDesc.Creator );
		desc.Version = gcnew Version( D3DSHADER_VERSION_MAJOR( nativeDesc.Version ), D3DSHADER_VERSION_MINOR( nativeDesc.Version ) );
		desc.Constants = nativeDesc.Constants;
		return desc;
	}
}
}