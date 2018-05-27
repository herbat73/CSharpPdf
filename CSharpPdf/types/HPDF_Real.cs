﻿using CSharpPdf.Objects;

namespace CSharpPdf.Types
{
    public class HPDF_Real : HPDF_Object
    {
        public double Value;

        public HPDF_Real(double value)
        {
            Value = value;
            Header.ObjClass = HPDF_Obj_Header.HPDF_OCLASS_REAL;
        }
    }
}
