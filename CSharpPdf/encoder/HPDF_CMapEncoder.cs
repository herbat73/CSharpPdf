using CSharpPdf.Streams;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CSharpPdf.Encoder
{
    public class HPDF_CMapEncoder : HPDF_Encoder
    {
        public HPDF_CMapEncoder(string name, Func<string> initFn)
        {
            Trace.WriteLine("HPDF_CMapEncoder");
        }

        public void WriteFn(HPDF_Stream stream)
        {
            Trace.WriteLine("WriteFn");
        }

        public void ReadFn()
        {
            Trace.WriteLine("ReadFn");
        }

        public override uint HPDF_Encoder_ToUnicode(uint code)
        {
            Trace.WriteLine("HPDF_Encoder_ToUnicode");
            return code;
        }

        public void GBK_EUC_H_Init(HPDF_CMapEncoder encoder)
        {
            Trace.WriteLine("GBK_EUC_H_Init");
        }

        public void HPDF_CMapEncoder_InitAttr()
        {
            Trace.WriteLine("HPDF_CMapEncoder_InitAttr");
        }

        public void HPDF_CMapEncoder_AddCMap()
        {
            Trace.WriteLine("HPDF_CMapEncoder_AddCMap");
        }

        public uint UnicodeToByte(uint value)
        {
            Trace.WriteLine("unicodeToByte");
            return value;
        }

    }
}
