using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Liberty.Infrastructure.Helpers
{
    public static class CryptoHelper
    {
        private const string cryptoKey = "awd34-X==awdjoawdO=TYcxvgDx";
        private static readonly byte[] IV = new byte[8] { 240, 3, 45, 29, 0, 76, 173, 59 };

        public static string Encrypt(string originalPassword)
        {
            if (originalPassword == null || originalPassword.Length == 0) return string.Empty;
            string result = string.Empty;
            try
            {
                byte[] buffer = Encoding.Default.GetBytes(originalPassword);
                TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
                MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();
                des.Key = MD5.ComputeHash(ASCIIEncoding.UTF32.GetBytes(cryptoKey));
                des.IV = IV;
                result = Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static string Decrypt(string encryptPassword)
        {
            if (encryptPassword == null || encryptPassword.Length == 0) return string.Empty;
            string result = string.Empty;
            try
            {
                byte[] buffer = Convert.FromBase64String(encryptPassword);
                TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
                MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();
                des.Key = MD5.ComputeHash(ASCIIEncoding.UTF32.GetBytes(cryptoKey));
                des.IV = IV;
                result = Encoding.Default.GetString(
                des.CreateDecryptor().TransformFinalBlock(
                buffer, 0, buffer.Length));
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }
}
