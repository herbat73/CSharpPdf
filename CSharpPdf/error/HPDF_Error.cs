using System;

namespace CSharpPdf.error
{
    public class HPDF_Error : Exception
    {
        public const int HPDF_OK = 0;
        public const int HPDF_ARRAY_COUNT_ERR = 0x1001;
        public const int HPDF_ARRAY_ITEM_NOT_FOUND = 0x1002;
        public const int HPDF_ARRAY_ITEM_UNEXPECTED_TYPE = 0x1003;
        public const int HPDF_BINARY_LENGTH_ERR = 0x1004;
        public const int HPDF_CANNOT_GET_PALLET = 0x1005;
        public const int HPDF_DICT_COUNT_ERR = 0x1007;
        public const int HPDF_DICT_ITEM_NOT_FOUND = 0x1008;
        public const int HPDF_DICT_ITEM_UNEXPECTED_TYPE = 0x1009;
        public const int HPDF_DICT_STREAM_LENGTH_NOT_FOUND = 0x100A;
        public const int HPDF_DOC_ENCRYPTDICT_NOT_FOUND = 0x100B;
        public const int HPDF_DOC_INVALID_OBJECT = 0x100C;
        /*                                                  = 0x100D */
        public const int HPDF_DUPLICATE_REGISTRATION = 0x100E;
        public const int HPDF_EXCEED_JWW_CODE_NUM_LIMIT = 0x100F;
        /*                                                  = 0x1010 */
        public const int HPDF_ENCRYPT_INVALID_PASSWORD = 0x1011;
        /*                                                  = 0x1012 */
        public const int HPDF_ERR_UNKNOWN_CLASS = 0x1013;
        public const int HPDF_EXCEED_GSTATE_LIMIT = 0x1014;
        public const int HPDF_FAILD_TO_ALLOC_MEM = 0x1015;
        public const int HPDF_FILE_IO_ERROR = 0x1016;
        public const int HPDF_FILE_OPEN_ERROR = 0x1017;
        /*                                                  = 0x1018 */
        public const int HPDF_FONT_EXISTS = 0x1019;
        public const int HPDF_FONT_INVALID_WIDTHS_TABLE = 0x101A;
        public const int HPDF_INVALID_AFM_HEADER = 0x101B;
        public const int HPDF_INVALID_ANNOTATION = 0x101C;
        /*                                                  = 0x101D */
        public const int HPDF_INVALID_BIT_PER_COMPONENT = 0x101E;
        public const int HPDF_INVALID_CHAR_MATRICS_DATA = 0x101F;
        public const int HPDF_INVALID_COLOR_SPACE = 0x1020;
        public const int HPDF_INVALID_COMPRESSION_MODE = 0x1021;
        public const int HPDF_INVALID_DATE_TIME = 0x1022;
        public const int HPDF_INVALID_DESTINATION = 0x1023;
        /*                                                  = 0x1024 */
        public const int HPDF_INVALID_DOCUMENT = 0x1025;
        public const int HPDF_INVALID_DOCUMENT_STATE = 0x1026;
        public const int HPDF_INVALID_ENCODER = 0x1027;
        public const int HPDF_INVALID_ENCODER_TYPE = 0x1028;
        /*                                                  = 0x1029 */
        /*                                                  = 0x102A */
        public const int HPDF_INVALID_ENCODING_NAME = 0x102B;
        public const int HPDF_INVALID_ENCRYPT_KEY_LEN = 0x102C;
        public const int HPDF_INVALID_FONTDEF_DATA = 0x102D;
        public const int HPDF_INVALID_FONTDEF_TYPE = 0x102E;
        public const int HPDF_INVALID_FONT_NAME = 0x102F;
        public const int HPDF_INVALID_IMAGE = 0x1030;
        public const int HPDF_INVALID_JPEG_DATA = 0x1031;
        public const int HPDF_INVALID_N_DATA = 0x1032;
        public const int HPDF_INVALID_OBJECT = 0x1033;
        public const int HPDF_INVALID_OBJ_ID = 0x1034;
        public const int HPDF_INVALID_OPERATION = 0x1035;
        public const int HPDF_INVALID_OUTLINE = 0x1036;
        public const int HPDF_INVALID_PAGE = 0x1037;
        public const int HPDF_INVALID_PAGES = 0x1038;
        public const int HPDF_INVALID_PARAMETER = 0x1039;
        /*                                                  = 0x103A */
        public const int HPDF_INVALID_PNG_IMAGE = 0x103B;
        public const int HPDF_INVALID_STREAM = 0x103C;
        public const int HPDF_MISSING_FILE_NAME_ENTRY = 0x103D;
        /*                                                  = 0x103E */
        public const int HPDF_INVALID_TTC_FILE = 0x103F;
        public const int HPDF_INVALID_TTC_INDEX = 0x1040;
        public const int HPDF_INVALID_WX_DATA = 0x1041;
        public const int HPDF_ITEM_NOT_FOUND = 0x1042;
        public const int HPDF_LIBPNG_ERROR = 0x1043;
        public const int HPDF_NAME_INVALID_VALUE = 0x1044;
        public const int HPDF_NAME_OUT_OF_RANGE = 0x1045;
        /*                                                  = 0x1046 */
        /*                                                  = 0x1047 */
        public const int HPDF_PAGE_INVALID_PARAM_COUNT = 0x1048;
        public const int HPDF_PAGES_MISSING_KIDS_ENTRY = 0x1049;
        public const int HPDF_PAGE_CANNOT_FIND_OBJECT = 0x104A;
        public const int HPDF_PAGE_CANNOT_GET_ROOT_PAGES = 0x104B;
        public const int HPDF_PAGE_CANNOT_RESTORE_GSTATE = 0x104C;
        public const int HPDF_PAGE_CANNOT_SET_PARENT = 0x104D;
        public const int HPDF_PAGE_FONT_NOT_FOUND = 0x104E;
        public const int HPDF_PAGE_INVALID_FONT = 0x104F;
        public const int HPDF_PAGE_INVALID_FONT_SIZE = 0x1050;
        public const int HPDF_PAGE_INVALID_GMODE = 0x1051;
        public const int HPDF_PAGE_INVALID_INDEX = 0x1052;
        public const int HPDF_PAGE_INVALID_ROTATE_VALUE = 0x1053;
        public const int HPDF_PAGE_INVALID_SIZE = 0x1054;
        public const int HPDF_PAGE_INVALID_XOBJECT = 0x1055;
        public const int HPDF_PAGE_OUT_OF_RANGE = 0x1056;
        public const int HPDF_REAL_OUT_OF_RANGE = 0x1057;
        public const int HPDF_STREAM_EOF = 0x1058;
        public const int HPDF_STREAM_READLN_CONTINUE = 0x1059;
        /*                                                  = 0x105A */
        public const int HPDF_STRING_OUT_OF_RANGE = 0x105B;
        public const int HPDF_THIS_FUNC_WAS_SKIPPED = 0x105C;
        public const int HPDF_TTF_CANNOT_EMBEDDING_FONT = 0x105D;
        public const int HPDF_TTF_INVALID_CMAP = 0x105E;
        public const int HPDF_TTF_INVALID_FOMAT = 0x105F;
        public const int HPDF_TTF_MISSING_TABLE = 0x1060;
        public const int HPDF_UNSUPPORTED_FONT_TYPE = 0x1061;
        public const int HPDF_UNSUPPORTED_FUNC = 0x1062;
        public const int HPDF_UNSUPPORTED_JPEG_FORMAT = 0x1063;
        public const int HPDF_UNSUPPORTED_TYPE1_FONT = 0x1064;
        public const int HPDF_XREF_COUNT_ERR = 0x1065;
        public const int HPDF_ZLIB_ERROR = 0x1066;
        public const int HPDF_INVALID_PAGE_INDEX = 0x1067;
        public const int HPDF_INVALID_URI = 0x1068;
        public const int HPDF_PAGE_LAYOUT_OUT_OF_RANGE = 0x1069;
        public const int HPDF_PAGE_MODE_OUT_OF_RANGE = 0x1070;
        public const int HPDF_PAGE_NUM_STYLE_OUT_OF_RANGE = 0x1071;
        public const int HPDF_ANNOT_INVALID_ICON = 0x1072;
        public const int HPDF_ANNOT_INVALID_BORDER_STYLE = 0x1073;
        public const int HPDF_PAGE_INVALID_DIRECTION = 0x1074;
        public const int HPDF_INVALID_FONT = 0x1075;
        public const int HPDF_PAGE_INSUFFICIENT_SPACE = 0x1076;
        public const int HPDF_PAGE_INVALID_DISPLAY_TIME = 0x1077;
        public const int HPDF_PAGE_INVALID_TRANSITION_TIME = 0x1078;
        public const int HPDF_INVALID_PAGE_SLIDESHOW_TYPE = 0x1079;
        public const int HPDF_EXT_GSTATE_OUT_OF_RANGE = 0x1080;
        public const int HPDF_INVALID_EXT_GSTATE = 0x1081;
        public const int HPDF_EXT_GSTATE_READ_ONLY = 0x1082;
        public const int HPDF_INVALID_U3D_DATA = 0x1083;

        public int ErrorNo;
        public int DetailNo;

        public object UserData;

        public HPDF_Error(string message = "", int id = 0, int detailNo = 0) : base("Processing error.", new Exception(message))
        {
            ErrorNo = id;
            DetailNo = detailNo;
        }

        public void HPDF_Error_Init(object userData)
        {
            UserData = userData;
        }

        public void HPDF_Error_Reset()
        {
            ErrorNo = 0;
            DetailNo = 0;
        }


        public int HPDF_SetError(int errorNo, int detailNo)
        {
            ErrorNo = 0;
            DetailNo = 0;

            return ErrorNo;
        }
    }
}
