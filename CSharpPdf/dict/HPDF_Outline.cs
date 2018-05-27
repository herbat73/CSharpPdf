using CSharpPdf.Encoder;
using CSharpPdf.Types;
using CSharpPdf.Xref;
using CSharpPdf.Logger;

namespace CSharpPdf.Dict
{
    public class HPDF_Outline : HPDF_Dict
    {
        public const uint HPDF_OUTLINE_CLOSED = 0; 
		public const uint HPDF_OUTLINE_OPENED =  1;

        // TODO body
        public HPDF_Outline(bool root = false, HPDF_Outline parent = null, string title = "", HPDF_Encoder encoder = null, HPDF_Xref xref = null)
        {
            LibLogger.Debug(this.GetType(), "HPDF_Outline");
        }

        // TODO body
        public void beforeWriteFn()
        {
            LibLogger.Debug(this.GetType(), "beforeWriteFn");
        }

        // TODO body
        private uint CountChild()
        {
            LibLogger.Debug(this.GetType(), "CountChild");
            return 0;
        }

        // TODO body
        public HPDF_Outline HPDF_Outline_GetNext()
        {
            LibLogger.Debug(this.GetType(), "HPDF_Outline_GetNext");
            return null;
        }

        // TODO body
        public HPDF_Outline HPDF_Outline_GetFirst()
        {
            LibLogger.Debug(this.GetType(), "HPDF_Outline_GetFirst");
            return null;
        }

        // TODO body
        public HPDF_Outline HPDF_Outline_GetLast()
        {
            LibLogger.Debug(this.GetType(), "HPDF_Outline_GetLast");
            return null;
        }

        // TODO body
        public HPDF_Outline HPDF_Outline_GetOpened()
        {
            LibLogger.Debug(this.GetType(), "HPDF_Outline_GetOpened");
            return null;
        }

        // TODO body
        public void AddChild(HPDF_Outline item)
        {
            LibLogger.Debug(this.GetType(), "AddChild");
        }

        // TODO body
        public bool HPDF_Outline_Validate()
        {
            LibLogger.Debug(this.GetType(), "HPDF_Outline_Validate");
            return true;
        }

        // TODO body
        public void HPDF_Outline_SetDestination(HPDF_Destination dest)
        {
            LibLogger.Debug(this.GetType(), "HPDF_Outline_SetDestination");
        }

        // TODO body
        public void HPDF_Outline_SetOpened(bool opened)
        {
            LibLogger.Debug(this.GetType(), "HPDF_Outline_SetOpened");
        }

    }
}
