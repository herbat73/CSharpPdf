using CSharpPdf.Dict;
using CSharpPdf.Error;
using CSharpPdf.Objects;
using CSharpPdf.Types;
using CSharpPdf.Xref;
using System.Diagnostics;

namespace CSharpPdf.Catalog
{
    public class HPDF_Catalog : HPDF_Dict
    {
        private readonly string[] HPDF_PAGE_MODE_NAMES = {"UseNone", "UseOutlines", "UseThumbs", "FullScreen", "UseOC","UseAttachments"};

        public HPDF_Catalog(HPDF_Xref xref)
        {
            Trace.WriteLine("HPDF_Catalog");

            Header.ObjClass |= HPDF_Obj_Header.HPDF_OSUBCLASS_CATALOG;

            xref.HPDF_Xref_Add(this);

            HPDF_Dict_AddName("Type", "Catalog");
            HPDF_Dict_Add("Pages", new HPDF_Pages(null, xref));
        }

        public HPDF_Pages HPDF_Catalog_GetRoot()
		{	
            var pages = HPDF_Dict_GetItem( "Pages", HPDF_Obj_Header.HPDF_OCLASS_DICT);

		    if (pages==null || pages.Header.ObjClass != (HPDF_Obj_Header.HPDF_OSUBCLASS_PAGES |   HPDF_Obj_Header.HPDF_OCLASS_DICT))
		    {
		        throw new HPDF_Error( "HPDF_Catalog_GetRoot", HPDF_Error.HPDF_PAGE_CANNOT_GET_ROOT_PAGES, 0);
            }
		    return pages as HPDF_Pages; 
		}

		public	void	HPDF_Catalog_SetPageMode(int mode) 
		{
        	HPDF_Dict_AddName( "PageMode",  HPDF_PAGE_MODE_NAMES[mode] ); 	
		}

		public void HPDF_Catalog_SetOpenAction  (HPDF_Destination openAction)
		{
			if (openAction==null) {
				HPDF_Dict_RemoveElement ("OpenAction");
			}
			
			HPDF_Dict_Add ("OpenAction", openAction);
		}
    }
}
