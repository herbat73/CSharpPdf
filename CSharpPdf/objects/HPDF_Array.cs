namespace CSharpPdf.Objects
{
    public class HPDF_Array : HPDF_Object
    {
        public HPDF_List List; 

        public HPDF_Array()
        {
            Header.ObjClass = HPDF_Obj_Header.HPDF_OCLASS_ARRAY;
            List = new HPDF_List(HPDF_Conf.HPDF_DEF_ITEMS_PER_BLOCK);
        }
    }
}
