// Copyright (c) 2007-2010 SlimDX Group
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

//------------------------------------------------------------------------------
// <auto-generated>
//     Structs for SlimDX2.Windows namespace.
//     This code was generated by a tool.
//     Date : 11/08/2010 15:18:18
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;

namespace SlimDX2.Windows {

    
    /// <summary>	
    /// [This documentation is for preview only, and is subject to change in later releases. Blank topics are included as placeholders.]	
    /// </summary>	
    /// <unmanaged>Win32</unmanaged>
    [StructLayout(LayoutKind.Sequential, Pack = 0 )]
    internal  partial struct Win32 {	
        
        /// <summary>	
        /// </summary>	
        /// <unmanaged>TEXTMETRICW</unmanaged>
        [StructLayout(LayoutKind.Sequential, Pack = 0 )]
        public  partial struct Textmetricw {	
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>LONG tmHeight</unmanaged>
            public int TmHeight;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>LONG tmAscent</unmanaged>
            public int TmAscent;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>LONG tmDescent</unmanaged>
            public int TmDescent;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>LONG tmInternalLeading</unmanaged>
            public int TmInternalLeading;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>LONG tmExternalLeading</unmanaged>
            public int TmExternalLeading;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>LONG tmAveCharWidth</unmanaged>
            public int TmAveCharWidth;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>LONG tmMaxCharWidth</unmanaged>
            public int TmMaxCharWidth;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>LONG tmWeight</unmanaged>
            public int TmWeight;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>LONG tmOverhang</unmanaged>
            public int TmOverhang;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>LONG tmDigitizedAspectX</unmanaged>
            public int TmDigitizedAspectX;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>LONG tmDigitizedAspectY</unmanaged>
            public int TmDigitizedAspectY;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>wchar tmFirstChar</unmanaged>
            public char TmFirstChar;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>wchar tmLastChar</unmanaged>
            public char TmLastChar;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>wchar tmDefaultChar</unmanaged>
            public char TmDefaultChar;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>wchar tmBreakChar</unmanaged>
            public char TmBreakChar;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>BYTE tmItalic</unmanaged>
            public byte TmItalic;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>BYTE tmUnderlined</unmanaged>
            public byte TmUnderlined;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>BYTE tmStruckOut</unmanaged>
            public byte TmStruckOut;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>BYTE tmPitchAndFamily</unmanaged>
            public byte TmPitchAndFamily;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>BYTE tmCharSet</unmanaged>
            public byte TmCharSet;
        }
        
        /// <summary>	
        /// </summary>	
        /// <unmanaged>TEXTMETRICA</unmanaged>
        [StructLayout(LayoutKind.Sequential, Pack = 0 )]
        public  partial struct Textmetrica {	
            
            /// <summary>	
            /// The height (ascent + descent) of characters.	
            /// </summary>	
            /// <unmanaged>LONG tmHeight</unmanaged>
            public int TmHeight;
            
            /// <summary>	
            /// The ascent (units above the base line) of characters.	
            /// </summary>	
            /// <unmanaged>LONG tmAscent</unmanaged>
            public int TmAscent;
            
            /// <summary>	
            /// The descent (units below the base line) of characters.	
            /// </summary>	
            /// <unmanaged>LONG tmDescent</unmanaged>
            public int TmDescent;
            
            /// <summary>	
            /// The amount of leading (space) inside the bounds set by the tmHeight member. Accent marks and other diacritical characters may occur in this area. The designer may set this member to zero.	
            /// </summary>	
            /// <unmanaged>LONG tmInternalLeading</unmanaged>
            public int TmInternalLeading;
            
            /// <summary>	
            /// The amount of extra leading (space) that the application adds between rows. Since this area is outside the font, it contains no marks and is not altered by text output calls in either OPAQUE or TRANSPARENT mode. The designer may set this member to zero.	
            /// </summary>	
            /// <unmanaged>LONG tmExternalLeading</unmanaged>
            public int TmExternalLeading;
            
            /// <summary>	
            /// The average width of characters in the font (generally defined as the width of the letter x ). This value does not include the overhang required for bold or italic characters.	
            /// </summary>	
            /// <unmanaged>LONG tmAveCharWidth</unmanaged>
            public int TmAveCharWidth;
            
            /// <summary>	
            /// The width of the widest character in the font.	
            /// </summary>	
            /// <unmanaged>LONG tmMaxCharWidth</unmanaged>
            public int TmMaxCharWidth;
            
            /// <summary>	
            /// The weight of the font.	
            /// </summary>	
            /// <unmanaged>LONG tmWeight</unmanaged>
            public int TmWeight;
            
            /// <summary>	
            /// The extra width per string that may be added to some synthesized fonts. When synthesizing some attributes, such as bold or italic, graphics device interface (GDI) or a device may have to add width to a string on both a per-character and per-string basis. For example, GDI makes a string bold by expanding the spacing of each character and overstriking by an offset value; it italicizes a font by shearing the string. In either case, there is an overhang past the basic string. For bold strings, the overhang is the distance by which the overstrike is offset. For italic strings, the overhang is the amount the top of the font is sheared past the bottom of the font.The tmOverhang member enables the application to determine how much of the character width returned by a {{GetTextExtentPoint32}} function call on a single character is the actual character width and how much is the per-string extra width. The actual width is the extent minus the overhang.	
            /// </summary>	
            /// <unmanaged>LONG tmOverhang</unmanaged>
            public int TmOverhang;
            
            /// <summary>	
            /// The horizontal aspect of the device for which the font was designed.	
            /// </summary>	
            /// <unmanaged>LONG tmDigitizedAspectX</unmanaged>
            public int TmDigitizedAspectX;
            
            /// <summary>	
            /// The vertical aspect of the device for which the font was designed. The ratio of the tmDigitizedAspectX and tmDigitizedAspectY members is the aspect ratio of the device for which the font was designed.	
            /// </summary>	
            /// <unmanaged>LONG tmDigitizedAspectY</unmanaged>
            public int TmDigitizedAspectY;
            
            /// <summary>	
            /// The value of the first character defined in the font.	
            /// </summary>	
            /// <unmanaged>CHAR tmFirstChar</unmanaged>
            public byte TmFirstChar;
            
            /// <summary>	
            /// The value of the last character defined in the font.	
            /// </summary>	
            /// <unmanaged>CHAR tmLastChar</unmanaged>
            public byte TmLastChar;
            
            /// <summary>	
            /// The value of the character to be substituted for characters not in the font.	
            /// </summary>	
            /// <unmanaged>CHAR tmDefaultChar</unmanaged>
            public byte TmDefaultChar;
            
            /// <summary>	
            /// The value of the character that will be used to define word breaks for text justification.	
            /// </summary>	
            /// <unmanaged>CHAR tmBreakChar</unmanaged>
            public byte TmBreakChar;
            
            /// <summary>	
            /// Specifies an italic font if it is nonzero.	
            /// </summary>	
            /// <unmanaged>BYTE tmItalic</unmanaged>
            public byte TmItalic;
            
            /// <summary>	
            /// Specifies an underlined font if it is nonzero.	
            /// </summary>	
            /// <unmanaged>BYTE tmUnderlined</unmanaged>
            public byte TmUnderlined;
            
            /// <summary>	
            /// A strikeout font if it is nonzero.	
            /// </summary>	
            /// <unmanaged>BYTE tmStruckOut</unmanaged>
            public byte TmStruckOut;
            
            /// <summary>	
            /// Specifies information about the pitch, the technology, and the family of a physical font.The four low-order bits of this member specify information about the pitch and the technology of the font. A constant is defined for each of the four bits.ConstantMeaningTMPF_FIXED_PITCHIf this bit is set the font is a variable pitch font. If this bit is clear the font is a fixed pitch font. Note very carefully that those meanings are the opposite of what the constant name implies.TMPF_VECTORIf this bit is set the font is a vector font.TMPF_TRUETYPEIf this bit is set the font is a TrueType font.TMPF_DEVICEIf this bit is set the font is a device font.?An application should carefully test for qualities encoded in these low-order bits, making no arbitrary assumptions. For example, besides having their own bits set, TrueType and PostScript fonts set the TMPF_VECTOR bit. A monospace bitmap font has all of these low-order bits clear; a proportional bitmap font sets the TMPF_FIXED_PITCH bit. A Postscript printer device font sets the TMPF_DEVICE, TMPF_VECTOR, and TMPF_FIXED_PITCH bits.The four high-order bits of tmPitchAndFamily designate the font's font family. An application can use the value 0xF0 and the bitwise AND operator to mask out the four low-order bits of tmPitchAndFamily, thus obtaining a value that can be directly compared with font family names to find an identical match. For information about font families, see the description of the {{LOGFONT}} structure.	
            /// </summary>	
            /// <unmanaged>BYTE tmPitchAndFamily</unmanaged>
            public byte TmPitchAndFamily;
            
            /// <summary>	
            /// The character set of the font. The character set can be one of the following values.ANSI_CHARSETBALTIC_CHARSETCHINESEBIG5_CHARSETDEFAULT_CHARSETEASTEUROPE_CHARSETGB2312_CHARSETGREEK_CHARSETHANGUL_CHARSETMAC_CHARSETOEM_CHARSETRUSSIAN_CHARSETSHIFTJIS_CHARSETSYMBOL_CHARSETTURKISH_CHARSETVIETNAMESE_CHARSETKorean language edition of Windows:JOHAB_CHARSETMiddle East language edition of Windows:ARABIC_CHARSETHEBREW_CHARSETThai language edition of Windows:THAI_CHARSET	
            /// </summary>	
            /// <unmanaged>BYTE tmCharSet</unmanaged>
            public byte TmCharSet;
        }
        
        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <unmanaged>LOGFONTW</unmanaged>
        public  partial struct Logfontw {	
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>LONG lfHeight</unmanaged>
            public int LfHeight;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>LONG lfWidth</unmanaged>
            public int LfWidth;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>LONG lfEscapement</unmanaged>
            public int LfEscapement;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>LONG lfOrientation</unmanaged>
            public int LfOrientation;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>LONG lfWeight</unmanaged>
            public int LfWeight;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>BYTE lfItalic</unmanaged>
            public byte LfItalic;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>BYTE lfUnderline</unmanaged>
            public byte LfUnderline;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>BYTE lfStrikeOut</unmanaged>
            public byte LfStrikeOut;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>BYTE lfCharSet</unmanaged>
            public byte LfCharSet;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>BYTE lfOutPrecision</unmanaged>
            public byte LfOutPrecision;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>BYTE lfClipPrecision</unmanaged>
            public byte LfClipPrecision;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>BYTE lfQuality</unmanaged>
            public byte LfQuality;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>BYTE lfPitchAndFamily</unmanaged>
            public byte LfPitchAndFamily;
            
            /// <summary>	
            /// No documentation.	
            /// </summary>	
            /// <unmanaged>wchar lfFaceName[32]</unmanaged>
            public string LfFaceName;
    
            // Internal native struct used for marshalling
            [StructLayout(LayoutKind.Sequential, Pack = 0 )]
            internal unsafe partial struct __Native {	
                public int LfHeight;
                public int LfWidth;
                public int LfEscapement;
                public int LfOrientation;
                public int LfWeight;
                public byte LfItalic;
                public byte LfUnderline;
                public byte LfStrikeOut;
                public byte LfCharSet;
                public byte LfOutPrecision;
                public byte LfClipPrecision;
                public byte LfQuality;
                public byte LfPitchAndFamily;
                public fixed char LfFaceName[32];
    		    // Method to free native struct
                internal unsafe void __MarshalFree()
                {
                }
            }
    
            // Method to marshal from native to managed struct
            internal unsafe void __MarshalFrom(ref __Native @ref)
            {            
                this.LfHeight = @ref.LfHeight;
                this.LfWidth = @ref.LfWidth;
                this.LfEscapement = @ref.LfEscapement;
                this.LfOrientation = @ref.LfOrientation;
                this.LfWeight = @ref.LfWeight;
                this.LfItalic = @ref.LfItalic;
                this.LfUnderline = @ref.LfUnderline;
                this.LfStrikeOut = @ref.LfStrikeOut;
                this.LfCharSet = @ref.LfCharSet;
                this.LfOutPrecision = @ref.LfOutPrecision;
                this.LfClipPrecision = @ref.LfClipPrecision;
                this.LfQuality = @ref.LfQuality;
                this.LfPitchAndFamily = @ref.LfPitchAndFamily;
                fixed (char* __ptr = @ref.LfFaceName) this.LfFaceName = new string(__ptr, 0, 32);
            }
            // Method to marshal from managed struct tot native
            internal unsafe void __MarshalTo(ref __Native @ref)
            {
                @ref.LfHeight = this.LfHeight;
                @ref.LfWidth = this.LfWidth;
                @ref.LfEscapement = this.LfEscapement;
                @ref.LfOrientation = this.LfOrientation;
                @ref.LfWeight = this.LfWeight;
                @ref.LfItalic = this.LfItalic;
                @ref.LfUnderline = this.LfUnderline;
                @ref.LfStrikeOut = this.LfStrikeOut;
                @ref.LfCharSet = this.LfCharSet;
                @ref.LfOutPrecision = this.LfOutPrecision;
                @ref.LfClipPrecision = this.LfClipPrecision;
                @ref.LfQuality = this.LfQuality;
                @ref.LfPitchAndFamily = this.LfPitchAndFamily;
                fixed (char* __psrc = this.LfFaceName) fixed (char* __ptr = @ref.LfFaceName) Utilities.CopyMemory((IntPtr)__ptr, (IntPtr)__psrc, 32);
    		
    		}
        }
    }
}
