using CSharpPdf.Types;
using CSharpPdf.Types.Enums;
using CSharpPdf.Logger;
using System.Reflection;

namespace CSharpPdf.Encoder
{
    public class HPDF_Encoder
    {
        public const string HPDF_ENCODING_FONT_SPECIFIC = "FontSpecific";
        public const string HPDF_ENCODING_STANDARD = "StandardEncoding";
        public const string HPDF_ENCODING_MAC_ROMAN = "MacRomanEncoding";
        public const string HPDF_ENCODING_WIN_ANSI = "WinAnsiEncoding";
        public const string HPDF_ENCODING_ISO8859_2 = "ISO8859-2";
        public const string HPDF_ENCODING_ISO8859_3 = "ISO8859-3";
        public const string HPDF_ENCODING_ISO8859_4 = "ISO8859-4";
        public const string HPDF_ENCODING_ISO8859_5 = "ISO8859-5";
        public const string HPDF_ENCODING_ISO8859_6 = "ISO8859-6";
        public const string HPDF_ENCODING_ISO8859_7 = "ISO8859-7";
        public const string HPDF_ENCODING_ISO8859_8 = "ISO8859-8";
        public const string HPDF_ENCODING_ISO8859_9 = "ISO8859-9";
        public const string HPDF_ENCODING_ISO8859_10 = "ISO8859-10";
        public const string HPDF_ENCODING_ISO8859_11 = "ISO8859-11";
        public const string HPDF_ENCODING_ISO8859_13 = "ISO8859-13";
        public const string HPDF_ENCODING_ISO8859_14 = "ISO8859-14";
        public const string HPDF_ENCODING_ISO8859_15 = "ISO8859-15";
        public const string HPDF_ENCODING_ISO8859_16 = "ISO8859-16";
        public const string HPDF_ENCODING_CP1250 = "CP1250";
        public const string HPDF_ENCODING_CP1251 = "CP1251";
        public const string HPDF_ENCODING_CP1252 = "CP1252";
        public const string HPDF_ENCODING_CP1253 = "CP1253";
        public const string HPDF_ENCODING_CP1254 = "CP1254";
        public const string HPDF_ENCODING_CP1255 = "CP1255";
        public const string HPDF_ENCODING_CP1256 = "CP1256";
        public const string HPDF_ENCODING_CP1257 = "CP1257";
        public const string HPDF_ENCODING_CP1258 = "CP1258";
        public const string HPDF_ENCODING_KOI8_R = "KOI8-R";

        public const int HPDF_ENCODER_SIG_BYTES = 0x454E4344;

        public string Name;
        public uint Type;
        public string LangCode;
        public string CountryCode;
        public object Attr;

        public int sigBytes;

        public static readonly HPDF_BuiltinEncodingData[] HPDF_BUILTIN_ENCODINGS = {
            new HPDF_BuiltinEncodingData(HPDF_ENCODING_FONT_SPECIFIC, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_FONT_SPECIFIC,null ), 
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_STANDARD, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_STANDARD,null),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_MAC_ROMAN, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_MAC_ROMAN,null),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_WIN_ANSI, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI,null ),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_ISO8859_2, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_ISO8859_2),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_ISO8859_3, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_ISO8859_3),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_ISO8859_4, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_ISO8859_4),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_ISO8859_5, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_ISO8859_5),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_ISO8859_6, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_ISO8859_6),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_ISO8859_7, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_ISO8859_7),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_ISO8859_8, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_ISO8859_8),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_ISO8859_9, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_ISO8859_9),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_ISO8859_10, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_ISO8859_10),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_ISO8859_11, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_ISO8859_11),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_ISO8859_13, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_ISO8859_13),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_ISO8859_14, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_ISO8859_14),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_ISO8859_15, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_ISO8859_15),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_ISO8859_16, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_ISO8859_16),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_CP1250, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_CP1250),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_CP1251, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_CP1251),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_CP1252, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_CP1252),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_CP1253, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_CP1253),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_CP1254, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_CP1254),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_CP1255, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_CP1255),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_CP1256, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_CP1256),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_CP1257, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_CP1257),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_CP1258, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_CP1258),
		    new HPDF_BuiltinEncodingData(HPDF_ENCODING_KOI8_R, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_WIN_ANSI, HPDF_Encoding_Maps.HPDF_UNICODE_MAP_KOI8_R),
		    new HPDF_BuiltinEncodingData(null, (int)HPDF_BaseEncodings.HPDF_BASE_ENCODING_EOF,null)
        };

        public HPDF_Encoder()
        {

        }

        public HPDF_Encoder(string encodingName)
        {

        }

        public static HPDF_BuiltinEncodingData HPDF_BasicEncoder_FindBuiltinData(string encodingName) 
		 {
			uint i = 0;

            LibLogger.Debug(MethodBase.GetCurrentMethod().DeclaringType, " HPDF_BasicEncoder_FindBuiltinData");
			
			while (HPDF_BUILTIN_ENCODINGS[i].EncodingName!=null)
			{
			    if (HPDF_BUILTIN_ENCODINGS[i].EncodingName == encodingName)
			        break;
			    i++;
			}

			return HPDF_BUILTIN_ENCODINGS[i] ;
		}
        
        public uint ByteTypeFn(HPDF_ParseText text)
        {
            return (uint)HPDF_ByteType.HPDF_BYTE_TYPE_SINGLE;
        } 

        public virtual uint HPDF_Encoder_ToUnicode(uint code)
        {
            LibLogger.Debug(this.GetType(), " HPDF_Encoder_ToUnicode");
            return 0;
        }

    }
}
