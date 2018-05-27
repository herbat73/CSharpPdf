using CSharpPdf.Dict;
using CSharpPdf.Xref;
using CSharpPdf.Logger;

namespace CSharpPdf.Encrypt
{
    public class HPDF_EncryptDict : HPDF_Dict
    {
        public HPDF_EncryptDict(HPDF_Xref xref)
        {
            LibLogger.Debug(this.GetType(), "HPDF_EncryptDict");
        }

        public void HPDF_EncryptDict_CreateID(HPDF_Dict info, HPDF_Xref xref)
        {
            LibLogger.Debug(this.GetType(), "HPDF_EncryptDict_CreateID");
        }

        public void freeFn()
        {
            LibLogger.Debug(this.GetType(), "freeFn");
        }

        public void HPDF_EncryptDict_SetPassword(string ownerPass, string userPass)
        {
            LibLogger.Debug(this.GetType(), "HPDF_EncryptDict_SetPassword");
        }

        public bool HPDF_EncryptDict_Validate()
        {
            LibLogger.Debug(this.GetType(), "HPDF_EncryptDict_Validate");
            return true;
        }

        public HPDF_Encrypt HPDF_EncryptDict_GetAttr()
        {
            LibLogger.Debug(this.GetType(), "HPDF_EncryptDict_GetAttr");
            return null;
        }
    }   
}
