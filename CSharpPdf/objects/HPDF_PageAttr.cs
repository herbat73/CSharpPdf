using CSharpPdf.dict;
using CSharpPdf.encrypt;
using CSharpPdf.font;
using CSharpPdf.gstate;
using CSharpPdf.streams;
using CSharpPdf.types;
using CSharpPdf.types.enums;
using CSharpPdf.xref;
using System;
using System.Diagnostics;

namespace CSharpPdf.objects
{
    public class HPDF_PageAttr
    {
        public HPDF_Pages parent; 
		public HPDF_Dict fonts; 
		public HPDF_Dict xobjects; 
		public HPDF_Dict extGStates	;

        public HPDF_GState gstate;

        public object strPos;
        public HPDF_Point curPos ; 
		public HPDF_Point textPos;  
		public object textMatrix; 
		
		public uint gmode ; 
		public HPDF_Dict contents; 
		public HPDF_Stream stream; 
		public HPDF_Xref xref; 
		public uint compressionMode; 
		public object ver;

        public void InternalWriteText(string text)
        {
            Trace.WriteLine("InternalWriteText");

            var fontAttr = gstate.font.Attr;

            if (fontAttr.type == (uint)HPDF_FontType.HPDF_FONT_TYPE0_TT)
            {
                stream.HPDF_Stream_WriteStr("<");
                stream.HPDF_Stream_WriteBinary(HPDF_Utils.StringToByteArray(text), null as HPDF_Encrypt);
                stream.HPDF_Stream_WriteStr(">");
                return;
            }
            if (fontAttr.type == (uint)HPDF_FontType.HPDF_FONT_TYPE0_CID)
            {
                stream.HPDF_Stream_WriteStr("<");
                stream.HPDF_Stream_WriteBinary(HPDF_Utils.StringToByteArray(text, true, "cn-gb"), null as HPDF_Encrypt);
                stream.HPDF_Stream_WriteStr(">");
                return;
            }
            stream.HPDF_Stream_WriteEscapeText(text, fontAttr.encoder);

        }

        public static explicit operator HPDF_PageAttr(HPDF_FontAttr v)
        {
            throw new NotImplementedException();
        }
    }
}
