using CSharpPdf.Dict;
using CSharpPdf.Streams;
using CSharpPdf.Types;

namespace CSharpPdf.Font
{
    public class HPDF_FontDef
    {
        /*------ collection of flags for defining characteristics. ---*/
        public const int HPDF_FONT_FIXED_WIDTH = 1;
        public const int HPDF_FONT_SERIF = 2;
        public const int HPDF_FONT_SYMBOLIC = 4;
        public const int HPDF_FONT_SCRIPT = 8;
        /* Reserved                    16 */
        public const int HPDF_FONT_STD_CHARSET = 32;
        public const int HPDF_FONT_ITALIC = 64;
        /* Reserved                    128
           Reserved                    256
           Reserved                    512
           Reserved                    1024
           Reserved                    2048
           Reserved                    4096
           Reserved                    8192
           Reserved                    16384
           Reserved                    32768 */
        public const int HPDF_FONT_ALL_CAP = 65536;
        public const int HPDF_FONT_SMALL_CAP = 131072;
        public const int HPDF_FONT_FOURCE_BOLD = 262144;

        public const int HPDF_CID_W_TYPE_FROM_TO = 0;
        public const int HPDF_CID_W_TYPE_FROM_ARRAY = 1;

        public const uint HPDF_FONTDEF_SIG_BYTES = 0x464F4E54;

        public const int HPDF_TTF_FONT_TAG_LEN = 6;
        public const int HPDF_REQUIRED_TAGS_COUNT = 13;

        public uint sigBytes;
        public string baseFont;

        public uint type;

        public uint ascent;
        public uint descent;
        public uint flags;
        public HPDF_Box fontBBox;
        public int italicAngle;

        public uint stemv;
        public int avgWidth;
        public int maxWidth;
        public int missingWidth;
        public uint stemh;
        public uint xHeight;
        public uint capHeight;

        public HPDF_Dict descriptor;
        public HPDF_Stream data;
        public bool valid;
        public object attr;
    }
}
