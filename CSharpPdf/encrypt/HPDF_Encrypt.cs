using System;
using System.Reflection;
using CSharpPdf.Logger;

namespace CSharpPdf.Encrypt
{
    public class HPDF_Encrypt
    {
        public const int HPDF_ID_LEN = 16;
        public const int HPDF_PASSWD_LEN = 32;
        public const int HPDF_ENCRYPT_KEY_MAX = 16;
        public const int HPDF_MD5_KEY_LEN = 16;
        public const uint HPDF_PERMISSION_PAD = 0xFFFFFFC0;
        public const int HPDF_ARC4_BUF_SIZE = 256;

        private readonly byte[] HPDF_PADDING_STRING = {
            0x28, 0xBF, 0x4E, 0x5E, 0x4E, 0x75, 0x8A, 0x41,
            0x64, 0x00, 0x4E, 0x56, 0xFF, 0xFA, 0x01, 0x08,
            0x2E, 0x2E, 0x00, 0xB6, 0xD0, 0x68, 0x3E, 0x80,
            0x2F, 0x0C, 0xA9, 0xFE, 0x64, 0x53, 0x69, 0x7A };

        public int mode;

        public uint keyLen;
        public byte[] ownerPasswd = new byte[HPDF_PASSWD_LEN];
        public byte[] userPasswd = new byte[HPDF_PASSWD_LEN];
        public byte[] ownerKey = new byte[HPDF_PASSWD_LEN];
        public byte[] userKey = new byte[HPDF_PASSWD_LEN];

        public int permission;
        public byte[] encryptId = new byte[HPDF_ID_LEN];
        public byte[] encryptionKey = new byte[HPDF_MD5_KEY_LEN + 5];
        public byte[] md5EncryptionKey = new byte[HPDF_MD5_KEY_LEN];
        public HPDF_ARC4_Ctx arc4ctx = new HPDF_ARC4_Ctx();

        public HPDF_Encrypt()
        {
            LibLogger.Debug(this.GetType(), "HPDF_Encrypt");
        }

        public void HPDF_Encrypt_Init()
        {
            LibLogger.Debug(this.GetType(), "HPDF_Encrypt_Init");
        }

        public void HPDF_MD5Update(HPDF_MD5_CTX ctx, byte[] buf, uint len)
        {
            LibLogger.Debug(this.GetType(), "HPDF_Encrypt_Init");
        }

        public void HPDF_MD5Final(byte[] digest, HPDF_MD5_CTX ctx)
        {
            LibLogger.Debug(this.GetType(), "HPDF_MD5Final");
        }

        public void HPDF_Encrypt_InitKey(uint objectId, uint genNo)
        {
            LibLogger.Debug(this.GetType(), "HPDF_Encrypt_InitKey");
        }

        public void ARC4Init(HPDF_ARC4_Ctx ctx, byte[] key, uint keyLen)
        {
            LibLogger.Debug(this.GetType(), "ARC4Init");
        }

        public void HPDF_Encrypt_Reset()
        {
            LibLogger.Debug(this.GetType(), "HPDF_Encrypt_Init");
        }

        private void MD5ByteReverse(byte[] vec, uint longs)
        {
            LibLogger.Debug(this.GetType(), "MD5ByteReverse");
        }

        private static uint F1(uint x, uint y, uint z)
        {
            LibLogger.Debug(MethodBase.GetCurrentMethod().DeclaringType, "F1");
            return z ^ (x & (y ^ z));
        }

        private static uint F2(uint x, uint y, uint z)
        {
            LibLogger.Debug(MethodBase.GetCurrentMethod().DeclaringType, "F2");
            return F1(z, x, y);
        }

        private static uint F3(uint x, uint y, uint z)
        {
            LibLogger.Debug(MethodBase.GetCurrentMethod().DeclaringType, "F3");
            return (x ^ y ^ z);
        }

        private static uint F4(uint x, uint y, uint z)
        {
            LibLogger.Debug(MethodBase.GetCurrentMethod().DeclaringType, "F4");
            return (y ^ (x | ~z));
        }

        private uint HPDF_MD5STEP(Func<uint, uint, uint, uint> f, uint w, uint x, uint y, uint z, uint data, uint s)
        {
            LibLogger.Debug(this.GetType(), "HPDF_MD5STEP");

            uint ff = f(x, y, z);
            uint ret = w + ff + data;
            //ret = ret << s | ret >>> (32 - s);
            //ret += x;
            return ret;
        }

        private void MD5Transform()
        {
            LibLogger.Debug(this.GetType(), "MD5Transform");
        }

        private void HPDF_Encrypt_CreateOwnerKey()
        {
            LibLogger.Debug(this.GetType(), "HPDF_Encrypt_CreateOwnerKey");
        }

        private void HPDF_Encrypt_CreateEncryptionKey()
        {
            LibLogger.Debug(this.GetType(), "HPDF_Encrypt_CreateOwnerKey");
        }

        private void HPDF_Encrypt_CreateUserKey()
        {
            LibLogger.Debug(this.GetType(), "HPDF_Encrypt_CreateOwnerKey");
        }

        private void HPDF_Encrypt_CryptBuf()
        {
            LibLogger.Debug(this.GetType(), "HPDF_Encrypt_CryptBuf");
        }

        private void HPDF_PadOrTrancatePasswd()
        {
            LibLogger.Debug(this.GetType(), "HPDF_PadOrTrancatePasswd");
        }

    }
}
