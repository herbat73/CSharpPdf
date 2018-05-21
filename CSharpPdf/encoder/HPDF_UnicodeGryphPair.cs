namespace CSharpPdf.encoder
{
    public class HPDF_UnicodeGryphPair
    {
        public uint Unicode;
		public string GryphName;

        public HPDF_UnicodeGryphPair(uint unicode, string gryphName)
        {
            Unicode = unicode;
            GryphName = gryphName;
        }
    }
}
