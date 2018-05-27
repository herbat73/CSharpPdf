using CSharpPdf.Streams;
using System.Diagnostics;

namespace CSharpPdf.Encoder
{
    public class HPDF_BasicEncoder : HPDF_Encoder
    {
        public HPDF_BasicEncoder(string encodingName)
        {
            Trace.WriteLine("HPDF_BasicEncoder");
        }

        public HPDF_BasicEncoderAttr BasicEncoderAttr()
        {
            Trace.WriteLine("HPDF_Doc");
            return null;
        }

        public uint UnicodeToByte(uint value)
        {
            Trace.WriteLine("unicodeToByte");
            return value;
        }

        public void WriteFn(HPDF_Stream stream)
        {
            Trace.WriteLine("WriteFn");
        }

        public void ReadFn()
        {
            Trace.WriteLine("ReadFn");
        }

        public void HPDF_BasicEncoder_CopyMap(uint[] map)
        {
            Trace.WriteLine("HPDF_BasicEncoder_CopyMap");
        }

        public void HPDF_BasicEncoder_OverrideMap(uint[] map)
        {
            Trace.WriteLine("HPDF_BasicEncoder_OverrideMap");
        }

        public override uint HPDF_Encoder_ToUnicode(uint code)
        {
            Trace.WriteLine("HPDF_Encoder_ToUnicode");
            return code;
        }
    }
}
