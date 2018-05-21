namespace CSharpPdf.types
{
    public class HPDF_TransMatrix
    {
        public double A { get; set; }
		public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public HPDF_TransMatrix(double a = 0, double b=0, double c=0, double d=0, double x=0, double y=0)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            X = x;
            Y = y;
        }
    }
}
