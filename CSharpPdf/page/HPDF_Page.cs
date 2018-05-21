using CSharpPdf.dict;
using CSharpPdf.xref;
using System.Diagnostics;

namespace CSharpPdf.page
{
    public class HPDF_Page : HPDF_Dict
    {
        public HPDF_Page(HPDF_Xref xref)
        {
            Trace.WriteLine("HPDF_Page");
        }

    }
}
