using System.Diagnostics;

namespace CSharpPdf.Objects
{
    public class HPDF_Binary : HPDF_Object
    {
        public byte[] Value;
		public bool WriteTag = true;
		public bool ToHex = true;

        public HPDF_Binary(byte[] value)
        {
            Trace.WriteLine("HPDF_Binary");

            Value = value;
            Header.ObjClass = HPDF_Obj_Header.HPDF_OCLASS_BINARY;
        }

        public int Len()
        {
            return Value.Length;
        }
    }
}
