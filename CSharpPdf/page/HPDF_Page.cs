using CSharpPdf.Dict;
using CSharpPdf.Xref;
using CSharpPdf.Logger;

namespace CSharpPdf.Page
{
    public class HPDF_Page : HPDF_Dict
    {
        public HPDF_Page(HPDF_Xref xref)
        {
            LibLogger.Debug(this.GetType(), "HPDF_Page");
        }

    }
}
