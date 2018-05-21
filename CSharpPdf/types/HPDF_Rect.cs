namespace CSharpPdf.types
{
    public class HPDF_Rect
    {
        public double Bottom { get; set; }
        public double Top { get; set; }
        public double Left { get; set; }
        public double Right { get; set; }

        public HPDF_Rect(double left = 0, double bottom = 0, double right = 0, double top = 0)
        {
            Left = left;
            Bottom = bottom;
            Right = right;
            Top = top;
        }
    }
}
