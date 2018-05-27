using CSharpPdf.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPdf.Dict
{
    public  class HPDF_Null : HPDF_Dict
    {
        public HPDF_Null()
        {
            Header.ObjClass = HPDF_Obj_Header.HPDF_OCLASS_NULL;
        }
    }
}
