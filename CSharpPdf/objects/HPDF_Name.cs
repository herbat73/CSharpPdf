using CSharpPdf.error;

namespace CSharpPdf.objects
{
    public class HPDF_Name : HPDF_Object
    {
        public HPDF_Error Error; 
		public string Value;

        public HPDF_Name(string value)
        {
            Header.ObjClass = HPDF_Obj_Header.HPDF_OCLASS_NAME;
            Value = value;
        }
    }
}
