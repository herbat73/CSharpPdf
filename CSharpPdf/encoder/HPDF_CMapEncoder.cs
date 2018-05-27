using CSharpPdf.Streams;
using System;
using System.Collections.Generic;
using CSharpPdf.Logger;
using System.Text;

namespace CSharpPdf.Encoder
{
    public class HPDF_CMapEncoder : HPDF_Encoder
    {
        public HPDF_CMapEncoder(string name, Func<string> initFn)
        {
            LibLogger.Debug(this.GetType(), "HPDF_CMapEncoder");
        }

        public void WriteFn(HPDF_Stream stream)
        {
            LibLogger.Debug(this.GetType(), "WriteFn");
        }

        public void ReadFn()
        {
            LibLogger.Debug(this.GetType(), "ReadFn");
        }

        public override uint HPDF_Encoder_ToUnicode(uint code)
        {
            LibLogger.Debug(this.GetType(), "HPDF_Encoder_ToUnicode");
            return code;
        }

        public void GBK_EUC_H_Init(HPDF_CMapEncoder encoder)
        {
            LibLogger.Debug(this.GetType(), "GBK_EUC_H_Init");
        }

        public void HPDF_CMapEncoder_InitAttr()
        {
            LibLogger.Debug(this.GetType(), "HPDF_CMapEncoder_InitAttr");
        }

        public void HPDF_CMapEncoder_AddCMap()
        {
            LibLogger.Debug(this.GetType(), "HPDF_CMapEncoder_AddCMap");
        }

        public uint UnicodeToByte(uint value)
        {
            LibLogger.Debug(this.GetType(), "unicodeToByte");
            return value;
        }

    }
}
