namespace CSharpPdf.objects
{
    public class HPDF_Boolean : HPDF_Object
    {
        public bool Value;

        public HPDF_Boolean(bool value = false)
        {
            Value = value;
            Header.ObjClass = HPDF_Obj_Header.HPDF_OCLASS_BOOLEAN;
        }
    }
}