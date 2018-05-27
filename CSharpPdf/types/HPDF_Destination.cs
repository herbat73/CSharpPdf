using CSharpPdf.Objects;
using CSharpPdf.Page;
using CSharpPdf.Xref;
using System.Diagnostics;

namespace CSharpPdf.Types
{
    public class HPDF_Destination : HPDF_Array
    {
        private readonly string[] HPDF_DESTINATION_TYPE_NAMES  = { 
                                "XYZ",
                                "Fit",
                                "FitH",
                                "FitV",
                                "FitR",
                                "FitB",
                                "FitBH",
                                "FitBV"};

        public HPDF_Destination(HPDF_Page target, HPDF_Xref xref)
        {
            Trace.WriteLine("HPDF_Destination");
        }

        public void HPDF_Destination_SetXYZ(double left, double top, double zoom)
        {
            Trace.WriteLine("HPDF_Destination_SetXYZ");
        }

        public bool HPDF_Destination_Validate()
        {
            Trace.WriteLine("HPDF_Destination_Validate");
            return true;
        }

        public void HPDF_Destination_SetFit()
        {
            Trace.WriteLine("HPDF_Destination_SetFit");
        }
    }
}
