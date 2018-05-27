using CSharpPdf.Dict;
using CSharpPdf.Encoder;
using CSharpPdf.Encrypt;
using CSharpPdf.Error;
using CSharpPdf.Objects;
using CSharpPdf.Types;
using System.Diagnostics;

namespace CSharpPdf.Streams
{
    public class HPDF_Stream
    {
        public const int HPDF_STREAM_FILTER_NONE            = 0x0000;
		public const int HPDF_STREAM_FILTER_ASCIIHEX        = 0x0100;
		public const int HPDF_STREAM_FILTER_ASCII85         = 0x0200;
		public const int HPDF_STREAM_FILTER_FLATE_DECODE    = 0x0400;
		public const int HPDF_STREAM_FILTER_DCT_DECODE      = 0x0800;

        public uint sigBytes; 
    	public int type;

        public object attr;

        public HPDF_Stream()
        {
                
        }

        public void HPDF_Stream_WriteStr(string value)
        {
            Trace.WriteLine("HPDF_Stream_WriteStr");
        }

        public int HPDF_Stream_WriteStrUTF(string value)
        {
            Trace.WriteLine("HPDF_Stream_WriteStrUTF");
            return 0;
        }

        public void HPDF_Obj_WriteValue(HPDF_Object obj, HPDF_Encrypt e)
		{
            Trace.WriteLine("HPDF_Obj_WriteValue");

            HPDF_Obj_Header header = obj.Header;
		
            var clas = header.ObjClass & HPDF_Obj_Header.HPDF_OCLASS_ANY;

		    switch (clas)
		    {
		        case HPDF_Obj_Header.HPDF_OCLASS_NAME:
		            HPDF_Name_Write(obj as HPDF_Name);
		            break;
		        case HPDF_Obj_Header.HPDF_OCLASS_NUMBER:
		            HPDF_Number_Write(obj as HPDF_Number);
		            break;
		        case HPDF_Obj_Header.HPDF_OCLASS_REAL:
		            HPDF_Real_Write(obj as HPDF_Real);
		            break;
		        case HPDF_Obj_Header.HPDF_OCLASS_STRING:
		            HPDF_String_Write(obj as HPDF_String, e);
		            break;
		        case HPDF_Obj_Header.HPDF_OCLASS_BINARY:
		            HPDF_Binary_Write(obj as HPDF_Binary, e);
		            break;
		        case HPDF_Obj_Header.HPDF_OCLASS_ARRAY:
		            HPDF_Array_Write(obj as HPDF_Array, e);
		            break;
		        case HPDF_Obj_Header.HPDF_OCLASS_DICT:
		            HPDF_Dict_Write(obj as HPDF_Dict, e);
		            break;
		        case HPDF_Obj_Header.HPDF_OCLASS_BOOLEAN:
		            HPDF_Boolean_Write(obj as HPDF_Boolean);
		            break;
		        case HPDF_Obj_Header.HPDF_OCLASS_NULL:
		            HPDF_Stream_WriteStr( "null");
		            break;
		        default:
		        {
		         	throw new HPDF_Error("HPDF_Obj_WriteValue", HPDF_Error.HPDF_ERR_UNKNOWN_CLASS, 0 );
                }
            }
		}

        private void HPDF_Name_Write(HPDF_Name obj)
		{
            Trace.WriteLine("HPDF_Name_Write");
            HPDF_Stream_WriteEscapeName(obj.Value);
        }

        private void HPDF_Stream_WriteEscapeName(string value)
        {
            Trace.WriteLine("HPDF_Stream_WriteEscapeName");
        }

        private void HPDF_Number_Write(HPDF_Number obj)
        {
            Trace.WriteLine("HPDF_Number_Write");
            HPDF_Stream_WriteInt(obj.Value);
        }

        private void HPDF_Stream_WriteInt(int value)
        {
            Trace.WriteLine("HPDF_Stream_WriteInt");
            HPDF_Stream_WriteStr(value.ToString());
        }

        private void HPDF_Real_Write(HPDF_Real obj)
	    {
		    HPDF_Stream_WriteReal(obj.Value);
        }

        private void HPDF_Stream_WriteReal(double value)
        {
            Trace.WriteLine("HPDF_Stream_WriteReal");
        }

        private void HPDF_String_Write(HPDF_String obj, HPDF_Encrypt e)
        {
            Trace.WriteLine("HPDF_String_Write");
        }

        private void HPDF_Binary_Write(HPDF_Binary obj, HPDF_Encrypt e)
        {
            Trace.WriteLine("HPDF_Binary_Write");
        }

        public void HPDF_Stream_WriteBinaryString(string str, HPDF_Encrypt e)
        {
            Trace.WriteLine("HPDF_Stream_WriteBinaryString");
        }

        public void HPDF_Stream_WriteBinary(byte[] data, HPDF_Encrypt e, bool toHex = true)
        {
            Trace.WriteLine("HPDF_Stream_WriteBinary");
        }

        public void HPDF_Stream_Write(byte[] data)
        {
            Trace.WriteLine("HPDF_Stream_Write");
        }

        public void HPDF_Stream_WriteEscapeText(string str, HPDF_Encoder e)
        {
            Trace.WriteLine("HPDF_Stream_WriteEscapeText");
        }

        public void HPDF_Stream_WriteEscapeText2(string str, HPDF_Encoder e, uint len)
        {
            Trace.WriteLine("HPDF_Stream_WriteEscapeText2");
        }

        public void HPDF_Array_Write(HPDF_Array arr, HPDF_Encrypt e)
        {
            Trace.WriteLine("HPDF_Array_Write");
        }

        private void HPDF_Obj_Write(HPDF_Object obj, HPDF_Encrypt e)
        {
            Trace.WriteLine("HPDF_Obj_Write");
        }

        public void HPDF_Dict_Write(HPDF_Dict obj, HPDF_Encrypt e)
        {
            Trace.WriteLine("HPDF_Dict_Write");
        }

        private void HPDF_Boolean_Write(HPDF_Boolean obj)
        {
            Trace.WriteLine("HPDF_Boolean_Write");
        }

        public void HPDF_Stream_WriteToStream(HPDF_Stream stream, uint filter, HPDF_Encrypt e)
        {
            Trace.WriteLine("HPDF_Stream_WriteToStream");
        }

        public byte[] HPDF_Stream_Read(uint len)
        {
            Trace.WriteLine("HPDF_Stream_Read");
            return null;
        }

        public void HPDF_Stream_Seek(int pos, int mode)
        {
            Trace.WriteLine("HPDF_Stream_Seek");
        }

        private void HPDF_Stream_Free()
        {
            Trace.WriteLine("HPDF_Stream_Free");
        }

        public void HPDF_Stream_WriteUInt(uint value)
        {
            Trace.WriteLine("HPDF_Stream_WriteUInt");
        }

        public void HPDF2_Stream_Read_UInt4()
        {
            Trace.WriteLine("HPDF2_Stream_Read_UInt4");
        }

        public uint HPDF2_Stream_Read_UInt2()
        {
            Trace.WriteLine("HPDF2_Stream_Read_UInt2");
            return 0;
        }

        public void WriteUINT16(uint value)
        {
            Trace.WriteLine("WriteUINT32");
        }

        public void WriteUINT32(uint value)
        {
            Trace.WriteLine("WriteUINT32");
        }

        public void WriteINT16(int value)
        {
            Trace.WriteLine("WriteINT16");
        }

        public void WriteINT32(int value)
        {
            Trace.WriteLine("WriteINT32");
        }

        public void HPDF_MemStream_Rewrite(byte[] buf, int size)
        {
            Trace.WriteLine("HPDF_MemStream_Rewrite");
        }

        // https://www.codeproject.com/Tips/830793/Net-ZLib-Implementation
        //private void CheckError(ZStream z, int err, string msg)
        //{
        //    Trace.WriteLine("HPDF_Stream_Free");
        //}

        private bool HPDF_Stream_Validate()
        {
            Trace.WriteLine("HPDF_Stream_Validate");
            return true;
        }

    }
}
