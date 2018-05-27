using CSharpPdf.Dict;
using CSharpPdf.Xref;
using System.Diagnostics;

namespace CSharpPdf.Page
{
    public class HPDF_Page : HPDF_Dict
    {
        public HPDF_Page(HPDF_Xref xref)
        {
            Trace.WriteLine("HPDF_Page");
        }

    }
}
