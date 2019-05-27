using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace CDStoreManagement.Utils
{
    public class EncryptedPassword
    {
        public static string encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding uTF8 = new UTF8Encoding();
                byte[] datas = md5.ComputeHash(uTF8.GetBytes(value));
                return Convert.ToBase64String(datas);
            }
        }
        
    }
}
