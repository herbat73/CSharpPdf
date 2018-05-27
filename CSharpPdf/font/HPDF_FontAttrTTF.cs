using CSharpPdf.Types;
using System.Diagnostics;

namespace CSharpPdf.Font
{
    public class HPDF_FontAttrTTF : HPDF_FontAttr
    {
        public override HPDF_TextWidth textWidthFn(HPDF_Font font, string text, uint len)
        {
            Trace.WriteLine("HPDF_TTFont_TextWidth");

            var ret = new HPDF_TextWidth(0, 0, 0, 0);
            ///uint b = 0;

            //if (this.widths!=null)
            //{
            //    for (int i = 0 ; i < len; i++ ) {
            //        b = text.ToCharArray()[i]; 
            //        // transform unicode to byte
            //        if (encoder!=null)
            //            b = encoder.unicodeToByte(b);

            //        ret.NumChars++;
            //        ret.Width += font.CharWidth(b);

            //        if (HPDF_Utils.HPDF_IS_WHITE_SPACE(b))
            //        {
            //            ret.NumSpace++;
            //            ret.NumWords++;
            //        }
            //    }
            //}

            //if (HPDF_Utils.HPDF_IS_WHITE_SPACE(b))
            //    return null;
            //else
            //    ret.NumWords++;

            return ret;
        }

        private int CharWidth(HPDF_Font font, int code)
		{
            Trace.WriteLine("CharWidth");

            //if ( this.used[code] == 0 )
            //         {
            //         uint unicode = encoder.HPDF_Encoder_ToUnicode(code);

            //         used[code] = 1;
            //         widths[code] = fontdef.HPDF_TTFontDef_GetCharWidth(unicode);
            //         }

            //return widths[code];

            return 0;
        }

        public override double measureTextFn(HPDF_Font font, string text, uint len,
                                    double width, double fontSize, double charSpace, double wordSpace, bool wordwrap, C_NumberPointer realWidth)
        {
            Trace.WriteLine("HPDF_TTFont_MeasureText");
            return 0;

            //double w = 0;
            //uint tmpLen = 0;
            //uint i;

            //for (i = 0; i < len; i++)
            //{
            //    uint b = text.ToCharArray()[i];

            //    // use encoder
            //    if (encoder!=null)
            //        b = encoder.unicodeToByte(b);

            //    if (HPDF_Utils.HPDF_IS_WHITE_SPACE(b))
            //    {
            //        tmpLen = i + 1;

            //        if (realWidth!=null)
            //            realWidth.Value = w;

            //        w += wordSpace;
            //    }
            //    else if (!wordwrap)
            //    {
            //        tmpLen = i;

            //        if (realWidth != null)
            //            realWidth.Value = w;
            //    }

            //    w += font.CharWidth(b) * fontSize / 1000;

            //    /* 2006.08.04 break when it encountered  line feed */
            //    if (w > width || b == 0x0A)
            //        return tmpLen;

            //    if (i > 0)
            //        w += charSpace;
            //}

            ///* all of text can be put in the specified width */
            //if (realWidth != null)
            //    realWidth.Value = w;

            //return len;
        }
    }
}
