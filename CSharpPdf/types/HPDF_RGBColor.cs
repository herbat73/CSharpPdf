using System;

namespace CSharpPdf.types
{
    public class HPDF_RGBColor
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public static HPDF_RGBColor COLOR_BLACK  = new HPDF_RGBColor( 0,0,0 );

        public HPDF_RGBColor(int r = 0, int g = 0, int b = 0)
        {
            R = r;
            G = g;
            B = b;
        }

        public void FromString(string pString)
		{
			string cr = pString.Substring(1,2);
            string cg = pString.Substring(3,2);
            string cb = pString.Substring(5,2);

            R = Convert.ToInt32(cr, 16);
            G = Convert.ToInt32(cg, 16);
            B = Convert.ToInt32(cb, 16);
        }
    }
}
