namespace CSharpPdf.encoder
{
    public class HPDF_CidRange_Rec
    {
        public uint From;
		public uint To;
		public uint Cid;

        public HPDF_CidRange_Rec(uint from, uint to, uint cid)
        {
            From = from;
            To = to;
            Cid = cid;
        }
    }
}