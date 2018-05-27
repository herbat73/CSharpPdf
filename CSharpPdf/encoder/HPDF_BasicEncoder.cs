using CSharpPdf.Streams;
using CSharpPdf.Logger;

namespace CSharpPdf.Encoder
{
    public class HPDF_BasicEncoder : HPDF_Encoder
    {
        public HPDF_BasicEncoder(string encodingName)
        {
            LibLogger.Debug(this.GetType(), "HPDF_BasicEncoder");
        }

        public HPDF_BasicEncoderAttr BasicEncoderAttr()
        {
            LibLogger.Debug(this.GetType(), "HPDF_Doc");
            return null;
        }

        public uint UnicodeToByte(uint value)
        {
            LibLogger.Debug(this.GetType(), "unicodeToByte");
            return value;
        }

        public void WriteFn(HPDF_Stream stream)
        {
            LibLogger.Debug(this.GetType(), "WriteFn");
        }

        public void ReadFn()
        {
            LibLogger.Debug(this.GetType(), "ReadFn");
        }

        public void HPDF_BasicEncoder_CopyMap(uint[] map)
        {
            LibLogger.Debug(this.GetType(), "HPDF_BasicEncoder_CopyMap");
        }

        public void HPDF_BasicEncoder_OverrideMap(uint[] map)
        {
            LibLogger.Debug(this.GetType(), "HPDF_BasicEncoder_OverrideMap");
        }

        public override uint HPDF_Encoder_ToUnicode(uint code)
        {
            LibLogger.Debug(this.GetType(), "HPDF_Encoder_ToUnicode");
            return code;
        }
    }
}
