namespace CSharpPdf
{
    public class HPDF_Conf
    {
        /* default buffer size of memory-stream-object */
        public const int HPDF_STREAM_BUF_SIZ = 4096;
        /* default array size of list-object */
        public const int HPDF_DEF_ITEMS_PER_BLOCK = 20;
        /* default array size of cross-reference-table */
        public const int HPDF_DEFALUT_XREF_ENTRY_NUM = 1024;
        /* default array size of widths-table of cid-fontdef */
        public const int HPDF_DEF_CHAR_WIDTHS_NUM = 128;
        /* default array size of page-list-tablef */
        public const int HPDF_DEF_PAGE_LIST_NUM = 256;
        /* default array size of range-table of cid-fontdef */
        public const int HPDF_DEF_RANGE_TBL_NUM = 128;
        /* default buffer size of memory-pool-object */
        public const int HPDF_MPOOL_BUF_SIZ = 8192;
        public const int HPDF_MIN_MPOOL_BUF_SIZ = 256;
        public const int HPDF_MAX_MPOOL_BUF_SIZ = 1048576;
    }
}
