namespace CSharpPdf.Types
{
    public class HPDF_TextWidth
    {
        public uint NumChars { get; set; }
    	public uint Width { get; set; }
        public uint NumSpace { get; set; }
        public uint NumWords { get; set; }

        public HPDF_TextWidth(uint numchars = 0, uint width = 0, uint numspace = 0, uint numwords = 0)
        {
            NumChars = numchars;
            Width = width;
            NumSpace = numspace;
            NumWords = numwords;
        }
    }
}
