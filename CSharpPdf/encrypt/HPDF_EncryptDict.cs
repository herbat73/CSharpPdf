using CSharpPdf.Dict;
using CSharpPdf.Xref;
using System.Diagnostics;

namespace CSharpPdf.Encrypt
{
    public class HPDF_EncryptDict : HPDF_Dict
    {
        public HPDF_EncryptDict(HPDF_Xref xref)
        {
            Trace.WriteLine("HPDF_EncryptDict");
        }

        public void HPDF_EncryptDict_CreateID(HPDF_Dict info, HPDF_Xref xref)
        {
            Trace.WriteLine("HPDF_EncryptDict_CreateID");
        }

        public void freeFn()
        {
            Trace.WriteLine("freeFn");
        }

        public void HPDF_EncryptDict_SetPassword(string ownerPass, string userPass)
        {
            Trace.WriteLine("HPDF_EncryptDict_SetPassword");
        }

        public bool HPDF_EncryptDict_Validate()
        {
            Trace.WriteLine("HPDF_EncryptDict_Validate");
            return true;
        }

        public HPDF_Encrypt HPDF_EncryptDict_GetAttr()
        {
            Trace.WriteLine("HPDF_EncryptDict_GetAttr");
            return null;
        }
    }   
}
