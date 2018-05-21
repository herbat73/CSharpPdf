using CSharpPdf.dict;
using CSharpPdf.objects;
using CSharpPdf.xref;
using System.Diagnostics;

namespace CSharpPdf.catalog
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
    }
}
