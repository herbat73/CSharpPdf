namespace CSharpPdf.types
{
    public class HPDF_Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public HPDF_Point(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }
    }
}
