using CSharpPdf.Catalog;
using CSharpPdf.Dict;
using CSharpPdf.Encoder;
using CSharpPdf.Encrypt;
using CSharpPdf.Error;
using CSharpPdf.Font;
using CSharpPdf.Gstate;
using CSharpPdf.Image;
using CSharpPdf.Logger;
using CSharpPdf.Objects;
using CSharpPdf.Page;
using CSharpPdf.Streams;
using CSharpPdf.Types;
using CSharpPdf.Types.Enums;
using CSharpPdf.Xref;
using System;
using System.Diagnostics;

namespace CSharpPdf.Doc
{
    public class HPDF_Doc
    {
        private readonly string[] HPDF_VERSION_STR	= {
                            "%PDF-1.2\\012%\\267\\276\\255\\252\\012",
                            "%PDF-1.3\\012%\\267\\276\\255\\252\\012",
                            "%PDF-1.4\\012%\\267\\276\\255\\252\\012",
                            "%PDF-1.5\\012%\\267\\276\\255\\252\\012",
                            "%PDF-1.6\\012%\\267\\276\\255\\252\\012",
                            "%PDF-1.7\\012%\\267\\276\\255\\252\\012" };

        public const int HPDF_MAJOR_VERSION             = 2;
		public const int HPDF_MINOR_VERSION             = 1;
		public const int HPDF_BUGFIX_VERSION            = 0;
		public const string HPDF_EXTRA_VERSION          = "";
		public const string HPDF_VERSION_TEXT           = "2.0.8";
		public const int HPDF_VERSION_ID                = 20100;         
		public const int HPDF_SIG_BYTES	                = 0x41504446;

        ///private delegate _userErrorFunc(); // user error handler function
        ///

        private readonly int sigBytes; 
		public int PdfVersion; 
		
		public double CompressionMode; 
		
		public HPDF_Error Error;
		
		public HPDF_Xref Xref ; 
		public HPDF_Pages RootPages;
		public HPDF_Pages CurPages; 
		public HPDF_Page CurPage; 
		
		public HPDF_List PageList;
		
		public HPDF_Dict Info; 
		public HPDF_Dict Trailer;
		
		public HPDF_Catalog Catalog;
		
		public double PagePerPages;
		public int CurPageNum;
		
		public HPDF_Stream Stream;  
		
		public HPDF_Encoder CurEncoder; 	
		public HPDF_List EncoderList; 
		
		
		/*** FONTS **/
		public HPDF_List FontdefList; 
		public HPDF_List FontMgr; 
		public string TtfontTag; 
			
		public HPDF_Outline Outlines; 
		
		/** Encrypt **/
		public bool EncryptOn; 
		public HPDF_EncryptDict EncryptDict;

        public HPDF_Doc(Func<string> userErrorFunc = null, object userData = null)
        {
            LibLogger.Debug(this.GetType(), "ctor");

            PdfVersion = (int)HPDF_PdfVer.HPDF_VER_13;
            sigBytes = HPDF_SIG_BYTES;
            CompressionMode = HPDF_Consts.HPDF_COMP_NONE;

            HPDF_NewDoc();
        }

        private void HPDF_NewDoc()
        {
            LibLogger.Debug(this.GetType(), "HPDF_NewDoc");

            HPDF_FreeDoc();
            Xref = new HPDF_Xref();
            Trailer = Xref.Trailer;

            FontMgr = new HPDF_List(HPDF_Conf.HPDF_DEF_ITEMS_PER_BLOCK);

            if (FontdefList == null)
                FontdefList = new HPDF_List(HPDF_Conf.HPDF_DEF_ITEMS_PER_BLOCK);
         
            if (EncoderList == null)
                EncoderList = new HPDF_List(HPDF_Conf.HPDF_DEF_ITEMS_PER_BLOCK);
         
            Catalog = new HPDF_Catalog(Xref);

           // RootPages = Catalog.HPDF_Catalog_GetRoot();

            //PageList = new HPDF_List(HPDF_Conf.HPDF_DEF_PAGE_LIST_NUM);

            //CurPages = RootPages;

            //var ptr = "CSharpPdf library ";
            //var version  = HPDF_GetVersion();

            //ptr += version;

            //HPDF_SetInfoAttr((int)HPDF_InfoType.HPDF_INFO_PRODUCER, ptr);

        }

        public void HPDF_FreeDoc()
        {
            Trace.WriteLine("HPDF_FreeDoc");

            if (Xref!=null)
            {
                Xref.HPDF_Xref_Free();
                Xref = null;
            }

            PdfVersion = (int)HPDF_PdfVer.HPDF_VER_13;
        }

        public void HPDF_SetPagesConfiguration()
        {
            Trace.WriteLine("HPDF_SetPagesConfiguration");
        }

        public void WriteHeader(HPDF_Stream stream)
        {
            Trace.WriteLine("WriteHeader");
        }

        public void PrepareTrailer()
        {
            Trace.WriteLine("PrepareTrailer");
        }

        public void HPDF_Doc_SetEncryptOn()
        {
            Trace.WriteLine("HPDF_Doc_SetEncryptOn");
        }

        public void HPDF_SetPassword(string ownerPass, string userPass)
        {
            Trace.WriteLine("HPDF_SetPassword");
        }

        public void HPDF_SetPermission(uint permission)
        {
            Trace.WriteLine("HPDF_SetPermission");
        }

        public void HPDF_SetEncryptionMode(uint mode, uint keyLen)
        {
            Trace.WriteLine("HPDF_SetEncryptionMode");
        }

        public void HPDF_Doc_SetEncryptOff()
        {
            Trace.WriteLine("HPDF_Doc_SetEncryptOff");
        }

        public void HPDF_Doc_PrepareEncryption()
        {
            Trace.WriteLine("HPDF_Doc_PrepareEncryption");
        }

        public void InternalSaveToStream(HPDF_Stream stream)
        {
            Trace.WriteLine("InternalSaveToStream");
        }

        public void HPDF_SaveToStream()
        {
            Trace.WriteLine("HPDF_SaveToStream");
        }

        public uint HPDF_GetStreamSize()
        {
            Trace.WriteLine("HPDF_GetStreamSize");
            return 0;
        }

        public HPDF_Page HPDF_GetCurrentPage()
        {
            Trace.WriteLine("HPDF_GetCurrentPage");
            return null;
        }

        public HPDF_Page HPDF_GetPageByIndex(uint index)
        {
            Trace.WriteLine("HPDF_GetPageByIndex");
            return null;
        }

        public HPDF_Pages HPDF_Doc_GetCurrentPages()
        {
            Trace.WriteLine("HPDF_Doc_GetCurrentPages");
            return null;
        }

        public void HPDF_Doc_SetCurrentPages()
        {
            Trace.WriteLine("HPDF_Doc_SetCurrentPages");
        }

        public void HPDF_Doc_SetCurrentPage(HPDF_Page page)
        {
            Trace.WriteLine("HPDF_Doc_SetCurrentPage");
        }

        public HPDF_Page HPDF_AddPage()
        {
            Trace.WriteLine("HPDF_AddPage");
            return null;
        }

        public HPDF_Pages HPDF_Doc_AddPagesTo(HPDF_Pages pages)
        {
            Trace.WriteLine("HPDF_AddPage");
            return null;
        }

        public bool HPDF_HasDoc()
        {
            Trace.WriteLine("HPDF_HasDoc");
            return true;
        }

        public HPDF_Page HPDF_InsertPage(HPDF_Page taget)
        {
            Trace.WriteLine("HPDF_InsertPage");
            return null;
        }

        ///**************************************************************************
        // FONT HANDLING
        // **************************************************************************

        public void FreeFontDefList()
        {
            Trace.WriteLine("FreeFontDefList");
        }

        public void CleanupFontDefList()
        {
            Trace.WriteLine("CleanupFontDefList");
        }

        public HPDF_FontDef HPDF_Doc_FindFontDef(string fontName)
        {
            Trace.WriteLine("HPDF_InsertPage");
            return null;
        }

        public HPDF_FontDef HPDF_Doc_RegisterFontDef(HPDF_FontDef fontdef)
        {
            Trace.WriteLine("HPDF_Doc_RegisterFontDef");
            return null;
        }

        public HPDF_FontDef HPDF_GetFontDef(string fontName)
        {
            Trace.WriteLine("HPDF_GetFontDef");
            return null;
        }

        ///**************************************************************************
        // Encoder Handling
        // **************************************************************************

        public HPDF_Encoder HPDF_Doc_FindEncoder(string encodingName)
        {
            Trace.WriteLine("HPDF_Doc_FindEncoder");
            return null;
        }

        public void HPDF_Doc_RegisterEncoder(HPDF_Encoder encoder)
        {
            Trace.WriteLine("HPDF_Doc_RegisterEncoder");
        }

        public HPDF_Encoder HPDF_GetEncoder(string encodingName)
        {
            Trace.WriteLine("HPDF_GetEncoder");
            return null;
        }

        public HPDF_Encoder HPDF_GetCurrentEncoder()
        {
            Trace.WriteLine("HPDF_GetCurrentEncoder");
            return null;
        }

        public void HPDF_SetCurrentEncoder(string encodingName)
        {
            Trace.WriteLine("HPDF_SetCurrentEncoder");
        }

        public void FreeEncoderList()
        {
            Trace.WriteLine("FreeEncoderList");
        }

        ///**************************************************************************
        // Font handling
        // **************************************************************************

        public string HPDF_GetVersion()
        {
            Trace.WriteLine("HPDF_GetVersion");
            return HPDF_VERSION_TEXT;
        }

        public void HPDF_SetInfoAttr(int type, string value)
        {
            Trace.WriteLine("HPDF_SetInfoAttr");
        }

        public HPDF_Dict GetInfo()
        {
            Trace.WriteLine("GetInfo");
            return null;
        }

        public HPDF_Font HPDF_GetFont(string fontName, string encodingName)
        {
            Trace.WriteLine("HPDF_GetFont");
            return null;
        }

        public HPDF_Font HPDF_Doc_FindFont(string fontName, string encodingName)
        {
            Trace.WriteLine("HPDF_Doc_FindFont");
            return null;
        }

        public string HPDF_LoadTTFontFromStream(byte[] fontData, bool embedding)
        {
            Trace.WriteLine("HPDF_LoadTTFontFromStream");
            return "";
        }
        public string HPDF_LoadType1FontFromStream(byte[] fontData, bool embedding)
        {
            Trace.WriteLine("HPDF_LoadTTFontFromStream");
            return "";
        }

        public void HPDF_SetPageMode()
        {
            Trace.WriteLine("HPDF_SetPageMode");
        }

        public void HPDF_SetCompressionMode(uint mode)
        {
            Trace.WriteLine("HPDF_SetCompressionMode");
        }

        public HPDF_PngImage HPDF_LoadPngImageFromByteArray(byte[] source)
        {
            Trace.WriteLine("HPDF_LoadPngImageFromByteArray");
            return null;
        }

        public HPDF_ExtGState HPDF_CreateExtGState()
        {
            Trace.WriteLine("HPDF_CreateExtGState");
            return null;
        }

        public void HPDF_UseCNSEncodings()
        {
            Trace.WriteLine("HPDF_UseCNSEncodings");
        }

        public void HPDF_UseCNSFonts()
        {
            Trace.WriteLine("HPDF_UseCNSFonts");
        }

        public void HPDF_SetOpenAction(HPDF_Destination openAction)
        {
            Trace.WriteLine("HPDF_SetOpenAction");
        }

    }
}
