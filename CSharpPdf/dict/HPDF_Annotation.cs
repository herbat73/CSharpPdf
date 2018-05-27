using CSharpPdf.Encoder;
using CSharpPdf.Objects;
using CSharpPdf.Types;
using CSharpPdf.Types.Enums;
using CSharpPdf.Xref;
using CSharpPdf.Logger;
using System.Reflection;

namespace CSharpPdf.Dict
{
    public class HPDF_Annotation : HPDF_Dict
    {
        public readonly string[] HPDF_ANNOT_TYPE_NAMES = {
			                        "Text",
			                        "Link",
			                        "Sound",
			                        "FreeText",
			                        "Stamp",
			                        "Square",
			                        "Circle",
			                        "StrikeOut",
			                        "Highlight",
			                        "Underline",
			                        "Ink",
			                        "FileAttachment",
			                        "Popup" };

        public readonly string[] HPDF_ANNOT_ICON_NAMES_NAMES = {
			                        "Comment",
			                        "Key",
			                        "Note",
			                        "Help",
			                        "NewParagraph",
			                        "Paragraph",
			                        "Insert" };


        // TODO: body
        public HPDF_Annotation(HPDF_Xref xref, uint type, HPDF_Rect rect)
        {
            LibLogger.Debug(this.GetType(), "HPDF_Annotation");
        }

        // TODO: body
        public void HPDF_Annotation_SetBorderStyle(uint subtype, double width, uint dash_on, uint dash_off, uint dash_phase)
        {
            LibLogger.Debug(this.GetType(), "HPDF_Annotation_SetBorderStyle");
        }

        public static HPDF_Annotation HPDF_LinkAnnot_New(HPDF_Xref xref, HPDF_Rect rect, HPDF_Destination dest)
        {
            LibLogger.Debug(MethodBase.GetCurrentMethod().DeclaringType, "HPDF_LinkAnnot_New");

            HPDF_Annotation annot = new HPDF_Annotation(xref, (uint)HPDF_AnnotType.HPDF_ANNOT_LINK, rect);
            annot.HPDF_Dict_Add("Dest", dest);

            return annot;
        }

        public HPDF_Annotation HPDF_URILinkAnnot_New(HPDF_Xref xref, HPDF_Rect rect, string uri)
        {
            LibLogger.Debug(this.GetType(), "HPDF_URILinkAnnot_New");

            HPDF_Annotation annot;
            HPDF_Dict action;

            annot = new HPDF_Annotation(xref, (uint)HPDF_AnnotType.HPDF_ANNOT_LINK, rect);

            /* create action dictionary */
            action = new HPDF_Dict();

            annot.HPDF_Dict_Add("A", action);

            action.HPDF_Dict_AddName("Type", "Action");
            action.HPDF_Dict_AddName("S", "URI");
            action.HPDF_Dict_Add("URI", new HPDF_String(uri, null));

            return annot;
        }

        // TODO: body
        public void HPDF_LinkAnnot_SetBorderStyle()
        {
            LibLogger.Debug(this.GetType(), "HPDF_LinkAnnot_SetBorderStyle");
        }

        // TODO: body
        public void HPDF_LinkAnnot_SetHighlightMode(uint mode)
        {
            LibLogger.Debug(this.GetType(), "HPDF_LinkAnnot_SetHighlightMode");
        }

        // TODO: body
        public void HPDF_TextAnnot_New(HPDF_Xref xref, HPDF_Rect rect, string text, HPDF_Encoder enecoder)
        {
            LibLogger.Debug(this.GetType(), "HPDF_TextAnnot_New");
        }

        // TODO: body
        public void HPDF_TextAnnot_SetIcon(HPDF_Annotation annot, uint icon)
        {
            LibLogger.Debug(this.GetType(), "HPDF_LinkAnnot_SetHighlightMode");
        }

        // TODO: body
        public void HPDF_TextAnnot_SetOpened(HPDF_Annotation annot, HPDF_Boolean opened)
        {
            LibLogger.Debug(this.GetType(), "HPDF_LinkAnnot_SetHighlightMode");
        }

        // TODO: body
        public bool HPDF_Annotation_Validate()
        {
            LibLogger.Debug(this.GetType(), "HPDF_LinkAnnot_SetHighlightMode");
            
            return true;
        }

        // TODO: body
        public bool CheckSubType(uint type)
        {
            LibLogger.Debug(this.GetType(), "CheckSubType");

            return true;
        }

    }
}
