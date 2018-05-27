namespace CSharpPdf.Types
{
    public class HPDF_CMYKColor
    {
        public int C { get; set; }
        public int M { get; set; }
        public int Y { get; set; }
        public int K { get; set; }

        public HPDF_CMYKColor(int c = 0, int m = 0, int y = 0, int k = 0)
        {
            C = c;
            M = m;
            Y = y;
            K = k;
        }
    }
}