namespace CSharpPdf.Objects
{
    public class HPDF_Obj_Header
    {
        public const uint HPDF_OTYPE_NONE                = 0x00000000;
		public const uint HPDF_OTYPE_DIRECT              = 0x80000000;
		public const uint HPDF_OTYPE_INDIRECT            = 0x40000000;
		public const uint HPDF_OTYPE_ANY   =             (HPDF_OTYPE_DIRECT | HPDF_OTYPE_INDIRECT);
		public const uint HPDF_OTYPE_HIDDEN =            0x10000000 ;
		
		public const uint HPDF_OCLASS_UNKNOWN  =         0x0001;
		public const uint HPDF_OCLASS_NULL   =           0x0002;
		public const uint HPDF_OCLASS_BOOLEAN =          0x0003;
		public const uint HPDF_OCLASS_NUMBER   =         0x0004;
		public const uint HPDF_OCLASS_REAL =             0x0005;
		public const uint HPDF_OCLASS_NAME  =            0x0006;
		public const uint HPDF_OCLASS_STRING  =          0x0007;
		public const uint HPDF_OCLASS_BINARY  =          0x0008;
		public const uint HPDF_OCLASS_ARRAY  =           0x0010;
		public const uint HPDF_OCLASS_DICT   =           0x0011;
		public const uint HPDF_OCLASS_PROXY  =           0x0012;
		public const uint HPDF_OCLASS_ANY   =            0x00FF;
		
		public const uint HPDF_OSUBCLASS_FONT  =         0x0100;
		public const uint HPDF_OSUBCLASS_CATALOG =       0x0200;
		public const uint HPDF_OSUBCLASS_PAGES =         0x0300;
		public const uint HPDF_OSUBCLASS_PAGE   =        0x0400;
		public const uint HPDF_OSUBCLASS_XOBJECT  =      0x0500;
		public const uint HPDF_OSUBCLASS_OUTLINE  =      0x0600;
		public const uint HPDF_OSUBCLASS_DESTINATION =   0x0700;
		public const uint HPDF_OSUBCLASS_ANNOTATION =    0x0800;
		public const uint HPDF_OSUBCLASS_ENCRYPT   =     0x0900;
		public const uint HPDF_OSUBCLASS_EXT_GSTATE  =   0x0A00;
		public const uint HPDF_OSUBCLASS_EXT_GSTATE_R  = 0x0B00; /* read only object */

        public uint ObjId; 
		public uint GenNo;
		public uint ObjClass;

        public HPDF_Obj_Header()
        {
        }

        public void HPDF_Obj_Free()
        {
        }
    }
}
