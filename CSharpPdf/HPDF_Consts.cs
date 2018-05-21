using CSharpPdf.types;
using CSharpPdf.types.enums;

namespace CSharpPdf
{
    public class HPDF_Consts
    {
        public const int HPDF_TRUE = 1;
        public const int HPDF_FALSE = 0;

        public const int HPDF_OK = 0;
        public const int HPDF_NOERROR = 0;

        /*----- default values -------------------------------------------------------*/
        /* buffer size which is required when we convert to character string. */
        public const int HPDF_TMP_BUF_SIZ = 512;
        public const int HPDF_SHORT_BUF_SIZ = 32;
        public const int HPDF_REAL_LEN = 11;
        public const int HPDF_INT_LEN = 11;
        public const int HPDF_TEXT_DEFAULT_LEN = 256;
        public const int HPDF_UNICODE_HEADER_LEN = 2;
        public const int HPDF_DATE_TIME_STR_LEN = 23;

        /* length of each item defined in PDF */
        public const int HPDF_BYTE_OFFSET_LEN = 10;
        public const int HPDF_OBJ_ID_LEN = 7;
        public const int HPDF_GEN_NO_LEN = 5;

        /* default value of Graphic State */
        public const string HPDF_DEF_FONT = "Helvetica";
        public const int HPDF_DEF_PAGE_LAYOUT = HPDF_PageLayout.HPDF_PAGE_LAYOUT_SINGLE;
        public const int HPDF_DEF_PAGE_MODE = HPDF_PageMode.HPDF_PAGE_MODE_USE_NONE;
        public const int HPDF_DEF_WORDSPACE = 0;
        public const int HPDF_DEF_CHARSPACE = 0;
        public const int HPDF_DEF_FONTSIZE = 10;
        public const int HPDF_DEF_HSCALING = 100;
        public const int HPDF_DEF_LEADING = 0;
        public const int HPDF_DEF_RENDERING_MODE = (int)HPDF_TextRenderingMode.HPDF_FILL;
        public const int HPDF_DEF_RISE = 0;
        public const int HPDF_DEF_RAISE = HPDF_DEF_RISE;
        public const int HPDF_DEF_LINEWIDTH = 1;
        public const int HPDF_DEF_LINECAP = HPDF_LineCap.HPDF_BUTT_END;
        public const int HPDF_DEF_LINEJOIN = (int)HPDF_LineJoin.HPDF_MITER_JOIN;
        public const int HPDF_DEF_MITERLIMIT = 10;
        public const int HPDF_DEF_FLATNESS = 1;
        public const int HPDF_DEF_PAGE_NUM = 1;

        public const int HPDF_BS_DEF_WIDTH = 1;

        /* defalt page-size */
        public const double HPDF_DEF_PAGE_WIDTH = 595.276;
        public const double HPDF_DEF_PAGE_HEIGHT = 841.89;

        /*---------------------------------------------------------------------------*/
        /*----- compression mode ----------------------------------------------------*/

        public const int HPDF_COMP_NONE = 0x00;
        public const int HPDF_COMP_TEXT = 0x01;
        public const int HPDF_COMP_IMAGE = 0x02;
        public const int HPDF_COMP_METADATA = 0x04;
        public const int HPDF_COMP_ALL = 0x0F;
        /* public	static	const	 HPDF_COMP_BEST_COMPRESS   0x10
		 * public	static	const	 HPDF_COMP_BEST_SPEED      0x20
		 */
        public const int HPDF_COMP_MASK = 0xFF;


        /*----------------------------------------------------------------------------*/
        /*----- permission flags (only Revision 2 is supported)-----------------------*/

        public const int HPDF_ENABLE_READ = 0;
        public const int HPDF_ENABLE_PRINT = 4;
        public const int HPDF_ENABLE_EDIT_ALL = 8;
        public const int HPDF_ENABLE_COPY = 16;
        public const int HPDF_ENABLE_EDIT = 32;


        /*----------------------------------------------------------------------------*/
        /*------ viewer preferences definitions --------------------------------------*/

        public const int HPDF_HIDE_TOOLBAR = 1;
        public const int HPDF_HIDE_MENUBAR = 2;
        public const int HPDF_HIDE_WINDOW_UI = 4;
        public const int HPDF_FIT_WINDOW = 8;
        public const int HPDF_CENTER_WINDOW = 16;

        /*---------------------------------------------------------------------------*/
        /*------ limitation of object implementation (PDF1.4) -----------------------*/

        public const int HPDF_LIMIT_MAX_INT = 2147483647;
        public const int HPDF_LIMIT_MIN_INT = -2147483647;

        public const int HPDF_LIMIT_MAX_REAL = 32767;
        public const int HPDF_LIMIT_MIN_REAL = -32767;

        public const int HPDF_LIMIT_MAX_STRING_LEN = 65535;
        public const int HPDF_LIMIT_MAX_NAME_LEN = 127;

        public const int HPDF_LIMIT_MAX_ARRAY = 8191;
        public const int HPDF_LIMIT_MAX_DICT_ELEMENT = 4095;
        public const int HPDF_LIMIT_MAX_XREF_ELEMENT = 8388607;
        public const int HPDF_LIMIT_MAX_GSTATE = 28;
        public const int HPDF_LIMIT_MAX_DEVICE_N = 8;
        public const int HPDF_LIMIT_MAX_DEVICE_N_V15 = 32;
        public const int HPDF_LIMIT_MAX_CID = 65535;
        public const int HPDF_MAX_GENERATION_NUM = 65535;

        public const int HPDF_MIN_PAGE_HEIGHT = 3;
        public const int HPDF_MIN_PAGE_WIDTH = 3;
        public const int HPDF_MAX_PAGE_HEIGHT = 14400;
        public const int HPDF_MAX_PAGE_WIDTH = 14400;
        public const int HPDF_MIN_MAGNIFICATION_FACTOR = 8;
        public const int HPDF_MAX_MAGNIFICATION_FACTOR = 3200;

        /*---------------------------------------------------------------------------*/
        /*------ limitation of various properties -----------------------------------*/

        public const int HPDF_MIN_PAGE_SIZE = 3;
        public const int HPDF_MAX_PAGE_SIZE = 14400;
        public const int HPDF_MIN_HORIZONTALSCALING = 10;
        public const int HPDF_MAX_HORIZONTALSCALING = 300;
        public const int HPDF_MIN_WORDSPACE = -30;
        public const int HPDF_MAX_WORDSPACE = 300;
        public const int HPDF_MIN_CHARSPACE = -30;
        public const int HPDF_MAX_CHARSPACE = 300;
        public const int HPDF_MAX_FONTSIZE = 300;
        public const int HPDF_MAX_ZOOMSIZE = 10;
        public const int HPDF_MAX_LEADING = 300;
        public const int HPDF_MAX_LINEWIDTH = 100;
        public const int HPDF_MAX_DASH_PATTERN = 100;

        public const int HPDF_MAX_JWW_NUM = 128;

        /*----------------------------------------------------------------------------*/
        /*----- country code definition ----------------------------------------------*/

        public const string HPDF_COUNTRY_AF = "AF"; /* AFGHANISTAN */
        public const string HPDF_COUNTRY_AL = "AL"; /* ALBANIA */
        public const string HPDF_COUNTRY_DZ = "DZ"; /* ALGERIA */
        public const string HPDF_COUNTRY_AS = "AS"; /* AMERICAN SAMOA */
        public const string HPDF_COUNTRY_AD = "AD"; /* ANDORRA */
        public const string HPDF_COUNTRY_AO = "AO"; /* ANGOLA */
        public const string HPDF_COUNTRY_AI = "AI"; /* ANGUILLA */
        public const string HPDF_COUNTRY_AQ = "AQ"; /* ANTARCTICA */
        public const string HPDF_COUNTRY_AG = "AG"; /* ANTIGUA AND BARBUDA */
        public const string HPDF_COUNTRY_AR = "AR"; /* ARGENTINA */
        public const string HPDF_COUNTRY_AM = "AM"; /* ARMENIA */
        public const string HPDF_COUNTRY_AW = "AW"; /* ARUBA */
        public const string HPDF_COUNTRY_AU = "AU"; /* AUSTRALIA */
        public const string HPDF_COUNTRY_AT = "AT"; /* AUSTRIA */
        public const string HPDF_COUNTRY_AZ = "AZ"; /* AZERBAIJAN */
        public const string HPDF_COUNTRY_BS = "BS"; /* BAHAMAS */
        public const string HPDF_COUNTRY_BH = "BH"; /* BAHRAIN */
        public const string HPDF_COUNTRY_BD = "BD"; /* BANGLADESH */
        public const string HPDF_COUNTRY_BB = "BB"; /* BARBADOS */
        public const string HPDF_COUNTRY_BY = "BY"; /* BELARUS */
        public const string HPDF_COUNTRY_BE = "BE"; /* BELGIUM */
        public const string HPDF_COUNTRY_BZ = "BZ"; /* BELIZE */
        public const string HPDF_COUNTRY_BJ = "BJ"; /* BENIN */
        public const string HPDF_COUNTRY_BM = "BM"; /* BERMUDA */
        public const string HPDF_COUNTRY_BT = "BT"; /* BHUTAN */
        public const string HPDF_COUNTRY_BO = "BO"; /* BOLIVIA */
        public const string HPDF_COUNTRY_BA = "BA"; /* BOSNIA AND HERZEGOWINA */
        public const string HPDF_COUNTRY_BW = "BW"; /* BOTSWANA */
        public const string HPDF_COUNTRY_BV = "BV"; /* BOUVET ISLAND */
        public const string HPDF_COUNTRY_BR = "BR"; /* BRAZIL */
        public const string HPDF_COUNTRY_IO = "IO"; /* BRITISH INDIAN OCEAN TERRITORY */
        public const string HPDF_COUNTRY_BN = "BN"; /* BRUNEI DARUSSALAM */
        public const string HPDF_COUNTRY_BG = "BG"; /* BULGARIA */
        public const string HPDF_COUNTRY_BF = "BF"; /* BURKINA FASO */
        public const string HPDF_COUNTRY_BI = "BI"; /* BURUNDI */
        public const string HPDF_COUNTRY_KH = "KH"; /* CAMBODIA */
        public const string HPDF_COUNTRY_CM = "CM"; /* CAMEROON */
        public const string HPDF_COUNTRY_CA = "CA"; /* CANADA */
        public const string HPDF_COUNTRY_CV = "CV"; /* CAPE VERDE */
        public const string HPDF_COUNTRY_KY = "KY"; /* CAYMAN ISLANDS */
        public const string HPDF_COUNTRY_CF = "CF"; /* CENTRAL AFRICAN REPUBLIC */
        public const string HPDF_COUNTRY_TD = "TD"; /* CHAD */
        public const string HPDF_COUNTRY_CL = "CL"; /* CHILE */
        public const string HPDF_COUNTRY_CN = "CN"; /* CHINA */
        public const string HPDF_COUNTRY_CX = "CX"; /* CHRISTMAS ISLAND */
        public const string HPDF_COUNTRY_CC = "CC"; /* COCOS (KEELING) ISLANDS */
        public const string HPDF_COUNTRY_CO = "CO"; /* COLOMBIA */
        public const string HPDF_COUNTRY_KM = "KM"; /* COMOROS */
        public const string HPDF_COUNTRY_CG = "CG"; /* CONGO */
        public const string HPDF_COUNTRY_CK = "CK"; /* COOK ISLANDS */
        public const string HPDF_COUNTRY_CR = "CR"; /* COSTA RICA */
        public const string HPDF_COUNTRY_CI = "CI"; /* COTE D'IVOIRE */
        public const string HPDF_COUNTRY_HR = "HR"; /* CROATIA (local name: Hrvatska) */
        public const string HPDF_COUNTRY_CU = "CU"; /* CUBA */
        public const string HPDF_COUNTRY_CY = "CY"; /* CYPRUS */
        public const string HPDF_COUNTRY_CZ = "CZ"; /* CZECH REPUBLIC */
        public const string HPDF_COUNTRY_DK = "DK"; /* DENMARK */
        public const string HPDF_COUNTRY_DJ = "DJ"; /* DJIBOUTI */
        public const string HPDF_COUNTRY_DM = "DM"; /* DOMINICA */
        public const string HPDF_COUNTRY_DO = "DO"; /* DOMINICAN REPUBLIC */
        public const string HPDF_COUNTRY_TP = "TP"; /* EAST TIMOR */
        public const string HPDF_COUNTRY_EC = "EC"; /* ECUADOR */
        public const string HPDF_COUNTRY_EG = "EG"; /* EGYPT */
        public const string HPDF_COUNTRY_SV = "SV"; /* EL SALVADOR */
        public const string HPDF_COUNTRY_GQ = "GQ"; /* EQUATORIAL GUINEA */
        public const string HPDF_COUNTRY_ER = "ER"; /* ERITREA */
        public const string HPDF_COUNTRY_EE = "EE"; /* ESTONIA */
        public const string HPDF_COUNTRY_ET = "ET"; /* ETHIOPIA */
        public const string HPDF_COUNTRY_FK = "FK"; /* FALKLAND ISLANDS (MALVINAS) */
        public const string HPDF_COUNTRY_FO = "FO"; /* FAROE ISLANDS */
        public const string HPDF_COUNTRY_FJ = "FJ"; /* FIJI */
        public const string HPDF_COUNTRY_FI = "FI"; /* FINLAND */
        public const string HPDF_COUNTRY_FR = "FR"; /* FRANCE */
        public const string HPDF_COUNTRY_FX = "FX"; /* FRANCE, METROPOLITAN */
        public const string HPDF_COUNTRY_GF = "GF"; /* FRENCH GUIANA */
        public const string HPDF_COUNTRY_PF = "PF"; /* FRENCH POLYNESIA */
        public const string HPDF_COUNTRY_TF = "TF"; /* FRENCH SOUTHERN TERRITORIES */
        public const string HPDF_COUNTRY_GA = "GA"; /* GABON */
        public const string HPDF_COUNTRY_GM = "GM"; /* GAMBIA */
        public const string HPDF_COUNTRY_GE = "GE"; /* GEORGIA */
        public const string HPDF_COUNTRY_DE = "DE"; /* GERMANY */
        public const string HPDF_COUNTRY_GH = "GH"; /* GHANA */
        public const string HPDF_COUNTRY_GI = "GI"; /* GIBRALTAR */
        public const string HPDF_COUNTRY_GR = "GR"; /* GREECE */
        public const string HPDF_COUNTRY_GL = "GL"; /* GREENLAND */
        public const string HPDF_COUNTRY_GD = "GD"; /* GRENADA */
        public const string HPDF_COUNTRY_GP = "GP"; /* GUADELOUPE */
        public const string HPDF_COUNTRY_GU = "GU"; /* GUAM */
        public const string HPDF_COUNTRY_GT = "GT"; /* GUATEMALA */
        public const string HPDF_COUNTRY_GN = "GN"; /* GUINEA */
        public const string HPDF_COUNTRY_GW = "GW"; /* GUINEA-BISSAU */
        public const string HPDF_COUNTRY_GY = "GY"; /* GUYANA */
        public const string HPDF_COUNTRY_HT = "HT"; /* HAITI */
        public const string HPDF_COUNTRY_HM = "HM"; /* HEARD AND MC DONALD ISLANDS */
        public const string HPDF_COUNTRY_HN = "HN"; /* HONDURAS */
        public const string HPDF_COUNTRY_HK = "HK"; /* HONG KONG */
        public const string HPDF_COUNTRY_HU = "HU"; /* HUNGARY */
        public const string HPDF_COUNTRY_IS = "IS"; /* ICELAND */
        public const string HPDF_COUNTRY_IN = "IN"; /* INDIA */
        public const string HPDF_COUNTRY_ID = "ID"; /* INDONESIA */
        public const string HPDF_COUNTRY_IR = "IR"; /* IRAN (ISLAMIC REPUBLIC OF) */
        public const string HPDF_COUNTRY_IQ = "IQ"; /* IRAQ */
        public const string HPDF_COUNTRY_IE = "IE"; /* IRELAND */
        public const string HPDF_COUNTRY_IL = "IL"; /* ISRAEL */
        public const string HPDF_COUNTRY_IT = "IT"; /* ITALY */
        public const string HPDF_COUNTRY_JM = "JM"; /* JAMAICA */
        public const string HPDF_COUNTRY_JP = "JP"; /* JAPAN */
        public const string HPDF_COUNTRY_JO = "JO"; /* JORDAN */
        public const string HPDF_COUNTRY_KZ = "KZ"; /* KAZAKHSTAN */
        public const string HPDF_COUNTRY_KE = "KE"; /* KENYA */
        public const string HPDF_COUNTRY_KI = "KI"; /* KIRIBATI */
        public const string HPDF_COUNTRY_KP = "KP"; /* KOREA, DEMOCRATIC PEOPLE'S REPUBLIC OF */
        public const string HPDF_COUNTRY_KR = "KR"; /* KOREA, REPUBLIC OF */
        public const string HPDF_COUNTRY_KW = "KW"; /* KUWAIT */
        public const string HPDF_COUNTRY_KG = "KG"; /* KYRGYZSTAN */
        public const string HPDF_COUNTRY_LA = "LA"; /* LAO PEOPLE'S DEMOCRATIC REPUBLIC */
        public const string HPDF_COUNTRY_LV = "LV"; /* LATVIA */
        public const string HPDF_COUNTRY_LB = "LB"; /* LEBANON */
        public const string HPDF_COUNTRY_LS = "LS"; /* LESOTHO */
        public const string HPDF_COUNTRY_LR = "LR"; /* LIBERIA */
        public const string HPDF_COUNTRY_LY = "LY"; /* LIBYAN ARAB JAMAHIRIYA */
        public const string HPDF_COUNTRY_LI = "LI"; /* LIECHTENSTEIN */
        public const string HPDF_COUNTRY_LT = "LT"; /* LITHUANIA */
        public const string HPDF_COUNTRY_LU = "LU"; /* LUXEMBOURG */
        public const string HPDF_COUNTRY_MO = "MO"; /* MACAU */
        public const string HPDF_COUNTRY_MK = "MK"; /* MACEDONIA, THE FORMER YUGOSLAV REPUBLIC OF */
        public const string HPDF_COUNTRY_MG = "MG"; /* MADAGASCAR */
        public const string HPDF_COUNTRY_MW = "MW"; /* MALAWI */
        public const string HPDF_COUNTRY_MY = "MY"; /* MALAYSIA */
        public const string HPDF_COUNTRY_MV = "MV"; /* MALDIVES */
        public const string HPDF_COUNTRY_ML = "ML"; /* MALI */
        public const string HPDF_COUNTRY_MT = "MT"; /* MALTA */
        public const string HPDF_COUNTRY_MH = "MH"; /* MARSHALL ISLANDS */
        public const string HPDF_COUNTRY_MQ = "MQ"; /* MARTINIQUE */
        public const string HPDF_COUNTRY_MR = "MR"; /* MAURITANIA */
        public const string HPDF_COUNTRY_MU = "MU"; /* MAURITIUS */
        public const string HPDF_COUNTRY_YT = "YT"; /* MAYOTTE */
        public const string HPDF_COUNTRY_MX = "MX"; /* MEXICO */
        public const string HPDF_COUNTRY_FM = "FM"; /* MICRONESIA, FEDERATED STATES OF */
        public const string HPDF_COUNTRY_MD = "MD"; /* MOLDOVA, REPUBLIC OF */
        public const string HPDF_COUNTRY_MC = "MC"; /* MONACO */
        public const string HPDF_COUNTRY_MN = "MN"; /* MONGOLIA */
        public const string HPDF_COUNTRY_MS = "MS"; /* MONTSERRAT */
        public const string HPDF_COUNTRY_MA = "MA"; /* MOROCCO */
        public const string HPDF_COUNTRY_MZ = "MZ"; /* MOZAMBIQUE */
        public const string HPDF_COUNTRY_MM = "MM"; /* MYANMAR */
        public const string HPDF_COUNTRY_NA = "NA"; /* NAMIBIA */
        public const string HPDF_COUNTRY_NR = "NR"; /* NAURU */
        public const string HPDF_COUNTRY_NP = "NP"; /* NEPAL */
        public const string HPDF_COUNTRY_NL = "NL"; /* NETHERLANDS */
        public const string HPDF_COUNTRY_AN = "AN"; /* NETHERLANDS ANTILLES */
        public const string HPDF_COUNTRY_NC = "NC"; /* NEW CALEDONIA */
        public const string HPDF_COUNTRY_NZ = "NZ"; /* NEW ZEALAND */
        public const string HPDF_COUNTRY_NI = "NI"; /* NICARAGUA */
        public const string HPDF_COUNTRY_NE = "NE"; /* NIGER */
        public const string HPDF_COUNTRY_NG = "NG"; /* NIGERIA */
        public const string HPDF_COUNTRY_NU = "NU"; /* NIUE */
        public const string HPDF_COUNTRY_NF = "NF"; /* NORFOLK ISLAND */
        public const string HPDF_COUNTRY_MP = "MP"; /* NORTHERN MARIANA ISLANDS */
        public const string HPDF_COUNTRY_NO = "NO"; /* NORWAY */
        public const string HPDF_COUNTRY_OM = "OM"; /* OMAN */
        public const string HPDF_COUNTRY_PK = "PK"; /* PAKISTAN */
        public const string HPDF_COUNTRY_PW = "PW"; /* PALAU */
        public const string HPDF_COUNTRY_PA = "PA"; /* PANAMA */
        public const string HPDF_COUNTRY_PG = "PG"; /* PAPUA NEW GUINEA */
        public const string HPDF_COUNTRY_PY = "PY"; /* PARAGUAY */
        public const string HPDF_COUNTRY_PE = "PE"; /* PERU */
        public const string HPDF_COUNTRY_PH = "PH"; /* PHILIPPINES */
        public const string HPDF_COUNTRY_PN = "PN"; /* PITCAIRN */
        public const string HPDF_COUNTRY_PL = "PL"; /* POLAND */
        public const string HPDF_COUNTRY_PT = "PT"; /* PORTUGAL */
        public const string HPDF_COUNTRY_PR = "PR"; /* PUERTO RICO */
        public const string HPDF_COUNTRY_QA = "QA"; /* QATAR */
        public const string HPDF_COUNTRY_RE = "RE"; /* REUNION */
        public const string HPDF_COUNTRY_RO = "RO"; /* ROMANIA */
        public const string HPDF_COUNTRY_RU = "RU"; /* RUSSIAN FEDERATION */
        public const string HPDF_COUNTRY_RW = "RW"; /* RWANDA */
        public const string HPDF_COUNTRY_KN = "KN"; /* SAINT KITTS AND NEVIS */
        public const string HPDF_COUNTRY_LC = "LC"; /* SAINT LUCIA */
        public const string HPDF_COUNTRY_VC = "VC"; /* SAINT VINCENT AND THE GRENADINES */
        public const string HPDF_COUNTRY_WS = "WS"; /* SAMOA */
        public const string HPDF_COUNTRY_SM = "SM"; /* SAN MARINO */
        public const string HPDF_COUNTRY_ST = "ST"; /* SAO TOME AND PRINCIPE */
        public const string HPDF_COUNTRY_SA = "SA"; /* SAUDI ARABIA */
        public const string HPDF_COUNTRY_SN = "SN"; /* SENEGAL */
        public const string HPDF_COUNTRY_SC = "SC"; /* SEYCHELLES */
        public const string HPDF_COUNTRY_SL = "SL"; /* SIERRA LEONE */
        public const string HPDF_COUNTRY_SG = "SG"; /* SINGAPORE */
        public const string HPDF_COUNTRY_SK = "SK"; /* SLOVAKIA (Slovak Republic) */
        public const string HPDF_COUNTRY_SI = "SI"; /* SLOVENIA */
        public const string HPDF_COUNTRY_SB = "SB"; /* SOLOMON ISLANDS */
        public const string HPDF_COUNTRY_SO = "SO"; /* SOMALIA */
        public const string HPDF_COUNTRY_ZA = "ZA"; /* SOUTH AFRICA */
        public const string HPDF_COUNTRY_ES = "ES"; /* SPAIN */
        public const string HPDF_COUNTRY_LK = "LK"; /* SRI LANKA */
        public const string HPDF_COUNTRY_SH = "SH"; /* ST. HELENA */
        public const string HPDF_COUNTRY_PM = "PM"; /* ST. PIERRE AND MIQUELON */
        public const string HPDF_COUNTRY_SD = "SD"; /* SUDAN */
        public const string HPDF_COUNTRY_SR = "SR"; /* SURINAME */
        public const string HPDF_COUNTRY_SJ = "SJ"; /* SVALBARD AND JAN MAYEN ISLANDS */
        public const string HPDF_COUNTRY_SZ = "SZ"; /* SWAZILAND */
        public const string HPDF_COUNTRY_SE = "SE"; /* SWEDEN */
        public const string HPDF_COUNTRY_CH = "CH"; /* SWITZERLAND */
        public const string HPDF_COUNTRY_SY = "SY"; /* SYRIAN ARAB REPUBLIC */
        public const string HPDF_COUNTRY_TW = "TW"; /* TAIWAN, PROVINCE OF CHINA */
        public const string HPDF_COUNTRY_TJ = "TJ"; /* TAJIKISTAN */
        public const string HPDF_COUNTRY_TZ = "TZ"; /* TANZANIA, UNITED REPUBLIC OF */
        public const string HPDF_COUNTRY_TH = "TH"; /* THAILAND */
        public const string HPDF_COUNTRY_TG = "TG"; /* TOGO */
        public const string HPDF_COUNTRY_TK = "TK"; /* TOKELAU */
        public const string HPDF_COUNTRY_TO = "TO"; /* TONGA */
        public const string HPDF_COUNTRY_TT = "TT"; /* TRINIDAD AND TOBAGO */
        public const string HPDF_COUNTRY_TN = "TN"; /* TUNISIA */
        public const string HPDF_COUNTRY_TR = "TR"; /* TURKEY */
        public const string HPDF_COUNTRY_TM = "TM"; /* TURKMENISTAN */
        public const string HPDF_COUNTRY_TC = "TC"; /* TURKS AND CAICOS ISLANDS */
        public const string HPDF_COUNTRY_TV = "TV"; /* TUVALU */
        public const string HPDF_COUNTRY_UG = "UG"; /* UGANDA */
        public const string HPDF_COUNTRY_UA = "UA"; /* UKRAINE */
        public const string HPDF_COUNTRY_AE = "AE"; /* UNITED ARAB EMIRATES */
        public const string HPDF_COUNTRY_GB = "GB"; /* UNITED KINGDOM */
        public const string HPDF_COUNTRY_US = "US"; /* UNITED STATES */
        public const string HPDF_COUNTRY_UM = "UM"; /* UNITED STATES MINOR OUTLYING ISLANDS */
        public const string HPDF_COUNTRY_UY = "UY"; /* URUGUAY */
        public const string HPDF_COUNTRY_UZ = "UZ"; /* UZBEKISTAN */
        public const string HPDF_COUNTRY_VU = "VU"; /* VANUATU */
        public const string HPDF_COUNTRY_VA = "VA"; /* VATICAN CITY STATE (HOLY SEE) */
        public const string HPDF_COUNTRY_VE = "VE"; /* VENEZUELA */
        public const string HPDF_COUNTRY_VN = "VN"; /* VIET NAM */
        public const string HPDF_COUNTRY_VG = "VG"; /* VIRGIN ISLANDS (BRITISH) */
        public const string HPDF_COUNTRY_VI = "VI"; /* VIRGIN ISLANDS (U.S.) */
        public const string HPDF_COUNTRY_WF = "WF"; /* WALLIS AND FUTUNA ISLANDS */
        public const string HPDF_COUNTRY_EH = "EH"; /* WESTERN SAHARA */
        public const string HPDF_COUNTRY_YE = "YE"; /* YEMEN */
        public const string HPDF_COUNTRY_YU = "YU"; /* YUGOSLAVIA */
        public const string HPDF_COUNTRY_ZR = "ZR"; /* ZAIRE */
        public const string HPDF_COUNTRY_ZM = "ZM"; /* ZAMBIA */
        public const string HPDF_COUNTRY_ZW = "ZW"; /* ZIMBABWE */

        /*----------------------------------------------------------------------------*/
        /*----- lang code definition -------------------------------------------------*/

        public const string HPDF_LANG_AA = "aa"; /* Afar */
        public const string HPDF_LANG_AB = "ab"; /* Abkhazian */
        public const string HPDF_LANG_AF = "af"; /* Afrikaans */
        public const string HPDF_LANG_AM = "am"; /* Amharic */
        public const string HPDF_LANG_AR = "ar"; /* Arabic */
        public const string HPDF_LANG_AS = "as"; /* Assamese */
        public const string HPDF_LANG_AY = "ay"; /* Aymara */
        public const string HPDF_LANG_AZ = "az"; /* Azerbaijani */
        public const string HPDF_LANG_BA = "ba"; /* Bashkir */
        public const string HPDF_LANG_BE = "be"; /* Byelorussian */
        public const string HPDF_LANG_BG = "bg"; /* Bulgarian */
        public const string HPDF_LANG_BH = "bh"; /* Bihari */
        public const string HPDF_LANG_BI = "bi"; /* Bislama */
        public const string HPDF_LANG_BN = "bn"; /* Bengali Bangla */
        public const string HPDF_LANG_BO = "bo"; /* Tibetan */
        public const string HPDF_LANG_BR = "br"; /* Breton */
        public const string HPDF_LANG_CA = "ca"; /* Catalan */
        public const string HPDF_LANG_CO = "co"; /* Corsican */
        public const string HPDF_LANG_CS = "cs"; /* Czech */
        public const string HPDF_LANG_CY = "cy"; /* Welsh */
        public const string HPDF_LANG_DA = "da"; /* Danish */
        public const string HPDF_LANG_DE = "de"; /* German */
        public const string HPDF_LANG_DZ = "dz"; /* Bhutani */
        public const string HPDF_LANG_EL = "el"; /* Greek */
        public const string HPDF_LANG_EN = "en"; /* English */
        public const string HPDF_LANG_EO = "eo"; /* Esperanto */
        public const string HPDF_LANG_ES = "es"; /* Spanish */
        public const string HPDF_LANG_ET = "et"; /* Estonian */
        public const string HPDF_LANG_EU = "eu"; /* Basque */
        public const string HPDF_LANG_FA = "fa"; /* Persian */
        public const string HPDF_LANG_FI = "fi"; /* Finnish */
        public const string HPDF_LANG_FJ = "fj"; /* Fiji */
        public const string HPDF_LANG_FO = "fo"; /* Faeroese */
        public const string HPDF_LANG_FR = "fr"; /* French */
        public const string HPDF_LANG_FY = "fy"; /* Frisian */
        public const string HPDF_LANG_GA = "ga"; /* Irish */
        public const string HPDF_LANG_GD = "gd"; /* Scots Gaelic */
        public const string HPDF_LANG_GL = "gl"; /* Galician */
        public const string HPDF_LANG_GN = "gn"; /* Guarani */
        public const string HPDF_LANG_GU = "gu"; /* Gujarati */
        public const string HPDF_LANG_HA = "ha"; /* Hausa */
        public const string HPDF_LANG_HI = "hi"; /* Hindi */
        public const string HPDF_LANG_HR = "hr"; /* Croatian */
        public const string HPDF_LANG_HU = "hu"; /* Hungarian */
        public const string HPDF_LANG_HY = "hy"; /* Armenian */
        public const string HPDF_LANG_IA = "ia"; /* Interlingua */
        public const string HPDF_LANG_IE = "ie"; /* Interlingue */
        public const string HPDF_LANG_IK = "ik"; /* Inupiak */
        public const string HPDF_LANG_IN = "in"; /* Indonesian */
        public const string HPDF_LANG_IS = "is"; /* Icelandic */
        public const string HPDF_LANG_IT = "it"; /* Italian */
        public const string HPDF_LANG_IW = "iw"; /* Hebrew */
        public const string HPDF_LANG_JA = "ja"; /* Japanese */
        public const string HPDF_LANG_JI = "ji"; /* Yiddish */
        public const string HPDF_LANG_JW = "jw"; /* Javanese */
        public const string HPDF_LANG_KA = "ka"; /* Georgian */
        public const string HPDF_LANG_KK = "kk"; /* Kazakh */
        public const string HPDF_LANG_KL = "kl"; /* Greenlandic */
        public const string HPDF_LANG_KM = "km"; /* Cambodian */
        public const string HPDF_LANG_KN = "kn"; /* Kannada */
        public const string HPDF_LANG_KO = "ko"; /* Korean */
        public const string HPDF_LANG_KS = "ks"; /* Kashmiri */
        public const string HPDF_LANG_KU = "ku"; /* Kurdish */
        public const string HPDF_LANG_KY = "ky"; /* Kirghiz */
        public const string HPDF_LANG_LA = "la"; /* Latin */
        public const string HPDF_LANG_LN = "ln"; /* Lingala */
        public const string HPDF_LANG_LO = "lo"; /* Laothian */
        public const string HPDF_LANG_LT = "lt"; /* Lithuanian */
        public const string HPDF_LANG_LV = "lv"; /* Latvian,Lettish */
        public const string HPDF_LANG_MG = "mg"; /* Malagasy */
        public const string HPDF_LANG_MI = "mi"; /* Maori */
        public const string HPDF_LANG_MK = "mk"; /* Macedonian */
        public const string HPDF_LANG_ML = "ml"; /* Malayalam */
        public const string HPDF_LANG_MN = "mn"; /* Mongolian */
        public const string HPDF_LANG_MO = "mo"; /* Moldavian */
        public const string HPDF_LANG_MR = "mr"; /* Marathi */
        public const string HPDF_LANG_MS = "ms"; /* Malay */
        public const string HPDF_LANG_MT = "mt"; /* Maltese */
        public const string HPDF_LANG_MY = "my"; /* Burmese */
        public const string HPDF_LANG_NA = "na"; /* Nauru */
        public const string HPDF_LANG_NE = "ne"; /* Nepali */
        public const string HPDF_LANG_NL = "nl"; /* Dutch */
        public const string HPDF_LANG_NO = "no"; /* Norwegian */
        public const string HPDF_LANG_OC = "oc"; /* Occitan */
        public const string HPDF_LANG_OM = "om"; /* (Afan)Oromo */
        public const string HPDF_LANG_OR = "or"; /* Oriya */
        public const string HPDF_LANG_PA = "pa"; /* Punjabi */
        public const string HPDF_LANG_PL = "pl"; /* Polish */
        public const string HPDF_LANG_PS = "ps"; /* Pashto,Pushto */
        public const string HPDF_LANG_PT = "pt"; /* Portuguese  */
        public const string HPDF_LANG_QU = "qu"; /* Quechua */
        public const string HPDF_LANG_RM = "rm"; /* Rhaeto-Romance */
        public const string HPDF_LANG_RN = "rn"; /* Kirundi */
        public const string HPDF_LANG_RO = "ro"; /* Romanian */
        public const string HPDF_LANG_RU = "ru"; /* Russian */
        public const string HPDF_LANG_RW = "rw"; /* Kinyarwanda */
        public const string HPDF_LANG_SA = "sa"; /* Sanskrit */
        public const string HPDF_LANG_SD = "sd"; /* Sindhi */
        public const string HPDF_LANG_SG = "sg"; /* Sangro */
        public const string HPDF_LANG_SH = "sh"; /* Serbo-Croatian */
        public const string HPDF_LANG_SI = "si"; /* Singhalese */
        public const string HPDF_LANG_SK = "sk"; /* Slovak */
        public const string HPDF_LANG_SL = "sl"; /* Slovenian */
        public const string HPDF_LANG_SM = "sm"; /* Samoan */
        public const string HPDF_LANG_SN = "sn"; /* Shona */
        public const string HPDF_LANG_SO = "so"; /* Somali */
        public const string HPDF_LANG_SQ = "sq"; /* Albanian */
        public const string HPDF_LANG_SR = "sr"; /* Serbian */
        public const string HPDF_LANG_SS = "ss"; /* Siswati */
        public const string HPDF_LANG_ST = "st"; /* Sesotho */
        public const string HPDF_LANG_SU = "su"; /* Sundanese */
        public const string HPDF_LANG_SV = "sv"; /* Swedish */
        public const string HPDF_LANG_SW = "sw"; /* Swahili */
        public const string HPDF_LANG_TA = "ta"; /* Tamil */
        public const string HPDF_LANG_TE = "te"; /* Tegulu */
        public const string HPDF_LANG_TG = "tg"; /* Tajik */
        public const string HPDF_LANG_TH = "th"; /* Thai */
        public const string HPDF_LANG_TI = "ti"; /* Tigrinya */
        public const string HPDF_LANG_TK = "tk"; /* Turkmen */
        public const string HPDF_LANG_TL = "tl"; /* Tagalog */
        public const string HPDF_LANG_TN = "tn"; /* Setswanato Tonga */
        public const string HPDF_LANG_TR = "tr"; /* Turkish */
        public const string HPDF_LANG_TS = "ts"; /* Tsonga */
        public const string HPDF_LANG_TT = "tt"; /* Tatar */
        public const string HPDF_LANG_TW = "tw"; /* Twi */
        public const string HPDF_LANG_UK = "uk"; /* Ukrainian */
        public const string HPDF_LANG_UR = "ur"; /* Urdu */
        public const string HPDF_LANG_UZ = "uz"; /* Uzbek */
        public const string HPDF_LANG_VI = "vi"; /* Vietnamese */
        public const string HPDF_LANG_VO = "vo"; /* Volapuk */
        public const string HPDF_LANG_WO = "wo"; /* Wolof */
        public const string HPDF_LANG_XH = "xh"; /* Xhosa */
        public const string HPDF_LANG_YO = "yo"; /* Yoruba */
        public const string HPDF_LANG_ZH = "zh"; /* Chinese */
        public const string HPDF_LANG_ZU = "zu"; /* Zulu */

        /** graphics mode **/
        public const int HPDF_GMODE_PAGE_DESCRIPTION = 0x0001;
        public const int HPDF_GMODE_PATH_OBJECT = 0x0002;
        public const int HPDF_GMODE_TEXT_OBJECT = 0x0004;
        public const int HPDF_GMODE_CLIPPING_PATH = 0x0008;
        public const int HPDF_GMODE_SHADING = 0x0010;
        public const int HPDF_GMODE_INLINE_IMAGE = 0x0020;
        public const int HPDF_GMODE_EXTERNAL_OBJECT = 0x0040;
    }
}
