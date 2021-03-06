﻿using CSharpPdf.Dict;
using CSharpPdf.Error;
using CSharpPdf.Xref;
using CSharpPdf.Logger;

namespace CSharpPdf.Objects
{
    public class HPDF_Pages : HPDF_Dict
    {
        public HPDF_Pages(HPDF_Pages parent, HPDF_Xref xref )
        {
            LibLogger.Debug(this.GetType(), "HPDF_Pages");

            Header.ObjClass |= HPDF_Obj_Header.HPDF_OSUBCLASS_PAGES;

            xref.HPDF_Xref_Add(this);

            HPDF_Dict_AddName("Type", "Pages");
            HPDF_Dict_Add("Kids", new HPDF_Array());
            HPDF_Dict_Add("Count", new HPDF_Number(0));

            if (parent!=null)
                parent.HPDF_Pages_AddKids(this);
        }
        
        public void HPDF_Pages_AddKids(HPDF_Dict kid)
        {
            LibLogger.Debug(this.GetType(), "HPDF_Pages_AddKids");

            HPDF_Array kids;
            HPDF_PageAttr pageAttr;

            if (kid.HPDF_Dict_GetItem("Parent", HPDF_Obj_Header.HPDF_OCLASS_DICT)==null)
            {
                Error = new HPDF_Error("HPDF_Pages_AddKids", HPDF_Error.HPDF_PAGE_CANNOT_SET_PARENT, 0);
            }

            kid.HPDF_Dict_Add("Parent", this);

            // C kids = (HPDF_Array )HPDF_Dict_GetItem (parent, "Kids", HPDF_OCLASS_ARRAY);
            kids = this.HPDF_Dict_GetItem("Kids", HPDF_Obj_Header.HPDF_OCLASS_ARRAY) as HPDF_Array;

            if (kids==null)
            {
                Error = new HPDF_Error("HPDF_Pages_AddKids", HPDF_Error.HPDF_PAGES_MISSING_KIDS_ENTRY, 0);
            }

            if (kid.Header.ObjClass == (HPDF_Obj_Header.HPDF_OCLASS_DICT | HPDF_Obj_Header.HPDF_OSUBCLASS_PAGE))
            {
                pageAttr =  (HPDF_PageAttr) kid.Attr;
                pageAttr.parent = this;
            }

            if (kid.Header.ObjClass == (HPDF_Obj_Header.HPDF_OCLASS_DICT | HPDF_Obj_Header.HPDF_OSUBCLASS_PAGE))
            {
                // TODO var	attr : HPDF_PageAttr = kid.attr ; 
                pageAttr = (HPDF_PageAttr) kid.Attr;
            }

            //kids.HPDF_Array_Add(kid); //(kids, kid); 
        }
    }
}
