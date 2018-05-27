namespace CSharpPdf.Types
{
    public class HPDF_Box
    {
        public double Bottom { get; set; }
		public double Top { get; set; }
        public double Left { get; set; }
        public double Right { get; set; }

        public HPDF_Box(double left  = 0, double bottom = 0, double right  = 0, double top  = 0)
        {
            Left = left;
            Bottom = bottom;
            Right = right;
            Top = top;
        }
    }
}
