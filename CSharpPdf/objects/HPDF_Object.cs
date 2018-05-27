namespace CSharpPdf.Objects
{
    public class HPDF_Object : IHPDF_Object
    {
        public HPDF_Obj_Header Header { get; set; }

        public HPDF_Object()
        {
            Header = new HPDF_Obj_Header();
        }

    }
}
