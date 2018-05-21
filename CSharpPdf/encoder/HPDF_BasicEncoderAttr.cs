namespace CSharpPdf.encoder
{
    public class HPDF_BasicEncoderAttr
    {
        public string BaseEncoding; 
		public uint FirstChar; 
		public uint LastChar ; 
		public int[] UnicodeMap = new int[256];
		public bool HasDifferences; 
		public int[] Differences = new int[256];
    }
}
