using CSharpPdf.Encoder;
using CSharpPdf.Logger;

namespace CSharpPdf.Objects
{
    public class HPDF_String : HPDF_Object
    {
        public HPDF_Encoder Encoder; 
    	public string Value;

        public HPDF_String(string value ="", HPDF_Encoder encoder = null)
        {
            LibLogger.Debug(this.GetType(), "HPDF_String");

            Value = value;
            Encoder = encoder;
            Header.ObjClass = HPDF_Obj_Header.HPDF_OCLASS_STRING;
        }

        public int Len()
        {
            return Value.Length;
        }

        public HPDF_String FromByteArray(byte[] ba)
        {
            LibLogger.Debug(this.GetType(), "FromByteArray");

            HPDF_String ret = new HPDF_String("");
            return ret;
        }
    }
}
