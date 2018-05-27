namespace CSharpPdf.Encoder
{
    public class HPDF_UnicodeMap
    {
        public uint Code; 
		public uint Unicode;

        public HPDF_UnicodeMap(uint code, uint unicode)
        {
            Code = code;
            Unicode = unicode;
        }       
    }
}
