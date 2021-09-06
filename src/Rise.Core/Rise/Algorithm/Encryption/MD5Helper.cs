using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Rise.Algorithm.Encryption
{
    public class MD5Helper
    {
        public static string ComputeHash(string str)
        {
            return ComputeHash(str, Encoding.Default);
        }

        public static string ComputeHash(string str, Encoding encoding)
        {
            using MD5 md5 = MD5.Create();
            var bytes = encoding.GetBytes(str);
            var hashBytes = md5.ComputeHash(bytes);
            return BitConverter.ToString(hashBytes).Replace("-", "");
        }
    }
}
