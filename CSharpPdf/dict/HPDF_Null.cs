using CSharpPdf.objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPdf.dict
{
    public  class HPDF_Null : HPDF_Dict
    {
        public HPDF_Null()
        {
            Header.ObjClass = HPDF_Obj_Header.HPDF_OCLASS_NULL;
        }
    }
}
