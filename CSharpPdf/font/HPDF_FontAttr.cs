using CSharpPdf.Dict;
using CSharpPdf.Encoder;
using CSharpPdf.Error;
using CSharpPdf.Types;
using CSharpPdf.Xref;
using System.Collections.Generic;

namespace CSharpPdf.Font
{
    public class HPDF_FontAttr
    {
        public uint type ; 
    	public uint writingMode;
        public HPDF_FontDef fontdef; 
        public HPDF_Encoder encoder; 
    	
    	public List<uint> widths;
    	public List<uint> used;
    	
    	public HPDF_Xref xref; 
    	public HPDF_Dict descendantFont; 
    	public HPDF_Dict mapStream;
        public HPDF_Dict cmapStream;
        public HPDF_Error Error;

        public HPDF_FontAttr()
        {
        }

        public virtual HPDF_TextWidth textWidthFn(HPDF_Font font, string text, uint len)
        {
            Error = new HPDF_Error("Function textWidthFn not implemented by HPDF_FontAttr");
            return null;
        }

        public virtual double measureTextFn(HPDF_Font font, string text, uint len, 
                                    double width, double fontSize, double charSpace, double wordSpace, bool wordwrap, C_NumberPointer realWidth)
        {
            Error = new HPDF_Error("Function measure text not implemented by HPDF_FontAttr");
            return 0;
        }
    }
}
