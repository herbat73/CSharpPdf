using System;
using System.Collections.Generic;
using CSharpPdf.Logger;
using System.Text;

namespace CSharpPdf.Encrypt
{
    public class HPDF_MD5_CTX
    {
        public List<uint> buf = new List<uint>(4);
		public List<uint> bits = new List<uint>(2);

        public byte[] inbytes = new byte[64];

        public void HPDF_MD5Init()
        {
            LibLogger.Debug(this.GetType(), "HPDF_MD5Init");

            buf[0] = 0x67452301;
            buf[1] = 0xefcdab89;
            buf[2] = 0x98badcfe;
            buf[3] = 0x10325476;

            bits[0] = 0;
            bits[1] = 0;
        }
    }
}
