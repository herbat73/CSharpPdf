namespace CSharpPdf.Objects
{
    public class HPDF_Proxy : HPDF_Object
    {
        public HPDF_Object Obj { get; set; }

        public HPDF_Proxy(HPDF_Object obj)
        {
            Header.ObjClass = HPDF_Obj_Header.HPDF_OCLASS_PROXY;        
            Obj = obj;
        }
    }
}
