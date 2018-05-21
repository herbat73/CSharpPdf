namespace CSharpPdf.encoder
{
    public class HPDF_BuiltinEncodingData
    {
        public string EncodingName; 
    	public int BaseEncoding; 
    	public uint[] OvewrrideMap;

        public HPDF_BuiltinEncodingData(string encodingName, int baseEncoding = 0, uint[] overrideMap = null)
        {
            EncodingName = encodingName;
            BaseEncoding = baseEncoding;
            OvewrrideMap = overrideMap;
        }
    }
}
