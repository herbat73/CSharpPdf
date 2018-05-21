using CSharpPdf.encoder;
using CSharpPdf.types;
using CSharpPdf.xref;
using System.Diagnostics;

namespace CSharpPdf.dict
{
    public class HPDF_Outline : HPDF_Dict
    {
        public const uint HPDF_OUTLINE_CLOSED = 0; 
		public const uint HPDF_OUTLINE_OPENED =  1;

        // TODO body
        public HPDF_Outline(bool root = false, HPDF_Outline parent = null, string title = "", HPDF_Encoder encoder = null, HPDF_Xref xref = null)
        {
            Trace.WriteLine("HPDF_Outline");
        }

        // TODO body
        public void beforeWriteFn()
        {
            Trace.WriteLine("beforeWriteFn");
        }

        // TODO body
        private uint CountChild()
        {
            Trace.WriteLine("CountChild");
            return 0;
        }

        // TODO body
        public HPDF_Outline HPDF_Outline_GetNext()
        {
            Trace.WriteLine("HPDF_Outline_GetNext");
            return null;
        }

        // TODO body
        public HPDF_Outline HPDF_Outline_GetFirst()
        {
            Trace.WriteLine("HPDF_Outline_GetFirst");
            return null;
        }

        // TODO body
        public HPDF_Outline HPDF_Outline_GetLast()
        {
            Trace.WriteLine("HPDF_Outline_GetLast");
            return null;
        }

        // TODO body
        public HPDF_Outline HPDF_Outline_GetOpened()
        {
            Trace.WriteLine("HPDF_Outline_GetOpened");
            return null;
        }

        // TODO body
        public void AddChild(HPDF_Outline item)
        {
            Trace.WriteLine("AddChild");
        }

        // TODO body
        public bool HPDF_Outline_Validate()
        {
            Trace.WriteLine("HPDF_Outline_Validate");
            return true;
        }

        // TODO body
        public void HPDF_Outline_SetDestination(HPDF_Destination dest)
        {
            Trace.WriteLine("HPDF_Outline_SetDestination");
        }

        // TODO body
        public void HPDF_Outline_SetOpened(bool opened)
        {
            Trace.WriteLine("HPDF_Outline_SetOpened");
        }

    }
}
