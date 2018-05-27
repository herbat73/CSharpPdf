using CSharpPdf.Objects;
using System;
using System.Collections.Generic;
using CSharpPdf.Logger;

namespace CSharpPdf.Encoder
{
    public class HPDF_CMapEncoderAttr
    {
        public List<uint> unicodeMap;
        public List<uint> cidMap;
		public List<uint> jwwLineHead;
		public HPDF_List cmapRange;
        public HPDF_List notdefRange;
        public HPDF_List codeSpaceRange;
        public uint writingMode;
        public string registr;
        public string ordering;
        public int suppliment;
		public Func<string> isLeadByteFn;
        public Func<string> isTrialByteFn; 
		public int uidOffset ;
        public List<uint> xuid;

        public HPDF_CMapEncoderAttr()
        {
            LibLogger.Debug(this.GetType(), "HPDF_CMapEncoderAttr");
        }
    }
}
