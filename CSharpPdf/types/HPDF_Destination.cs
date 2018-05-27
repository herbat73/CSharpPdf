using CSharpPdf.Objects;
using CSharpPdf.Page;
using CSharpPdf.Xref;
using CSharpPdf.Logger;

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
            LibLogger.Debug(this.GetType(), "HPDF_Destination");
        }

        public void HPDF_Destination_SetXYZ(double left, double top, double zoom)
        {
            LibLogger.Debug(this.GetType(), "HPDF_Destination_SetXYZ");
        }

        public bool HPDF_Destination_Validate()
        {
            LibLogger.Debug(this.GetType(), "HPDF_Destination_Validate");
            return true;
        }

        public void HPDF_Destination_SetFit()
        {
            LibLogger.Debug(this.GetType(), "HPDF_Destination_SetFit");
        }
    }
}
