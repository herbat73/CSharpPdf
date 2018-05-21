using CSharpPdf.font;
using CSharpPdf.types;
using CSharpPdf.xref;
using System.Diagnostics;

namespace CSharpPdf.gstate
{
    public class HPDF_GState
    {
        public HPDF_TransMatrix transMatrix;
        public double lineWidth; 
		public double lineCap;
		public double lineJoin; 
		public double miterLimit; 
		public HPDF_DashMode dashMode;
        public double flatness ;
		
		public double charSpace;
		public double wordSpace;
		public double hScalling;
		public double textLeading;
		public double renderingMode ; 
		public double textRise;
		
		public double csFill; 
		public double csStroke; 
		public HPDF_RGBColor rgbFill;
        public HPDF_RGBColor rgbStroke;
        public HPDF_CMYKColor cmykFill;
		public HPDF_CMYKColor cmykStroke;
		public double grayFill;
		public double grayStroke ;
		    
		public HPDF_Font font; 
		public double fontSize;
		public double writingMode; 
		
		public HPDF_GState prev; 
		public double depth;

        public HPDF_GState(HPDF_Xref xref)
        {
            Trace.WriteLine("HPDF_GState");
        }
    }
}
