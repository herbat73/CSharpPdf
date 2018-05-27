using System.Collections.Generic;
using CSharpPdf.Logger;

namespace CSharpPdf.Encrypt
{
    public class HPDF_ARC4_Ctx
    {
        public const int HPDF_ARC4_BUF_SIZE = 256;  
		
		public uint idx1;
		public uint idx2;
		public List<int> state = new List<int>(HPDF_ARC4_BUF_SIZE);

        public HPDF_ARC4_Ctx()
        {
            LibLogger.Debug(this.GetType(), "HPDF_ARC4_Ctx");
        }

        public void ARC4CryptBuf(byte[] inbytes, byte[] output, uint len)
        {
            LibLogger.Debug(this.GetType(), "ARC4CryptBuf");
        }

    }
}
