using CSharpPdf.error;
using CSharpPdf.types;
using System;
using System.Text;

namespace CSharpPdf
{
    public class HPDF_Utils
    {
        public string NEW_LINE = Char.ConvertFromUtf32(10);

		public	static HPDF_Point HPDF_ToPoint( double x , double y  )  
		{
			return new HPDF_Point(x, y);
		}

        public static string ParseString(string pStr ) 
		{
			string ret	= pStr;
            int idx  = ret.IndexOf( "\\" );

            while (idx >= 0) 
			{
				string tmp;
				tmp = ret.Substring(0,idx);
				double octal = Double.Parse(ret.Substring(idx+1,3));
				double dec = Math.Floor(octal / 100) * 64;
				octal = octal - Math.Floor(octal /100 ) * 100; 
				dec = dec + Math.Floor(octal / 10) * 8;
				octal = octal - Math.Floor(octal /10 ) * 10;
				dec = dec + octal; 
				
				tmp += Char.ConvertFromUtf32( Convert.ToInt32(dec) );
				tmp += ret.Substring(idx+4, 0xffffff );
				ret = tmp ; 
				idx = ret.IndexOf("\\");
			}
			return ret; 
		}
       
        public static bool HPDF_NEEDS_ESCAPE(string c)
		{
			if (Char.GetNumericValue(c, 0) < 0x21 || Char.GetNumericValue(c, 0) > 0x7e) 
				return true;
				
			if ( c.Equals("\\") ||
                 c.Equals('%') ||
                 c.Equals('#') ||
                 c.Equals('/') ||
                 c.Equals('(') ||
                 c.Equals(')') ||
                 c.Equals('<') ||
                 c.Equals('>') ||
                 c.Equals('[') ||
                 c.Equals(']') ||
                 c.Equals('{') ||
                 c.Equals('}')) 
                 	return true; 
               return false;
		}

        public static bool HPDF_IS_WHITE_SPACE(uint c) 
		{   
			if (c == 0x00 || 
             c == 0x09 || 
             c == 0x0A ||
             c == 0x0C || 
             c == 0x0D ||
             c == 0x20 )
             	return true;
             return false;  
	    }

        public static string IToA2(double value, int len) 
		{
			string ret	=	value.ToString(); 
			int l	= ret.Length;
            
			if (ret.Length < len) 
			{
				for (int i = 0 ; i<len-l-1 ; i++) 
					ret = "0" + ret; 	
			}
			return ret; 
		}

        public static string HPDF_IToA(double value) 
		{
			return Math.Round(value).ToString();
        }

        public static string HPDF_FToA(double value , int len = 0) 
		{
			double tmp = Math.Round(value * 1000);
			double r = tmp / 1000; 
			return r.ToString(); 
		}

        public static byte[] StringToByteArray(string str, bool multibyte = false, string encoding = "")
        {

            if (multibyte)
                Encoding.Unicode.GetBytes(str);

            return Encoding.ASCII.GetBytes(str);
        }

        public static uint HPDF_UInt16Swap(uint x) 
		{
            // swap adjacent 16-bit blocks
            x = (x >> 16) | (x << 16);
            // swap adjacent 8-bit blocks
            return ((x & 0xFF00FF00) >> 8) | ((x & 0x00FF00FF) << 8);
        }

        public static string ByteArrayReadLn(byte[] ba)
		{	
			//string buf; 
			//uint readSize ;
            //uint thisByte  = 0;
			string line  = "";  
	
		 //   if (ba==null)
		 //       throw new HPDF_Error("ByteArrayReadLn", HPDF_Error.HPDF_INVALID_PARAMETER, 0);
		        
			//while (thisByte != 	0x0A && thisByte != 0x0D && ba.Length > 0 )
			//{
   //             thisByte = ba.

			//    if (thisByte != 0x0A && thisByte != 0x0D )
			//    	line += String.fromCharCode(thisByte);
			//}
			return line ; 
        } 

}
}
