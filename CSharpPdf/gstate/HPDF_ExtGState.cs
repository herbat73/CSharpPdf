using CSharpPdf.Dict;
using CSharpPdf.Xref;
using System.Diagnostics;

namespace CSharpPdf.Gstate
{
    public class HPDF_ExtGState : HPDF_Dict
    {
        private readonly string[] HPDF_BM_NAMES = { 
                                      "Normal",
                                      "Multiply",
                                      "Screen",
                                      "Overlay",
                                      "Darken",
                                      "Lighten",
                                      "ColorDodge",
                                      "ColorBurn",
                                      "HardLight",
                                      "SoftLight",
                                      "Difference",
                                      "Exclusion"
                                      };

        public HPDF_ExtGState(HPDF_Xref xref)
        {
            Trace.WriteLine("HPDF_GState");
        }
    }
}
