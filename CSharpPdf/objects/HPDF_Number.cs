namespace CSharpPdf.Objects
{
    public class HPDF_Number : HPDF_Object
    {
        public int Value { get; set; }

        public HPDF_Number(int value)
        { 
            Header.ObjClass = HPDF_Obj_Header.HPDF_OCLASS_NUMBER;
            Value = value;
        }
    }
}
