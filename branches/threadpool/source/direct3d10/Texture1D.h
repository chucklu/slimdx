/*
* Copyright (c) 2007-2008 SlimDX Group
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
#pragma once

#include "../ComObject.h"

#include "Enums.h"
#include "Texture.h"

namespace SlimDX
{
	ref class DataStream;

	namespace Direct3D10
	{
		ref class Device;
		ref class ThreadPump;
		ref class DelayedResult;
		value class Texture1DDescription;
		
		public ref class Texture1D : public Texture
		{
			COMOBJECT(ID3D10Texture1D, Texture1D);
			
		public:
			property Texture1DDescription Description
			{
				Texture1DDescription get();
			}
			
			Texture1D( SlimDX::Direct3D10::Device^ device, Texture1DDescription description );
			static Texture1D^ FromPointer( System::IntPtr pointer );

			DataStream^ Map( int subresource, MapMode mode, MapFlags flags );
			void Unmap( int subresource );
			
			static Texture1D^ FromFile( SlimDX::Direct3D10::Device^ device, System::String^ fileName );
			static Texture1D^ FromMemory( SlimDX::Direct3D10::Device^ device, array<System::Byte>^ memory );
			static Texture1D^ FromStream( SlimDX::Direct3D10::Device^ device, System::IO::Stream^ stream, int sizeInBytes );
		};
	}
};