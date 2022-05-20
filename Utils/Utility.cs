using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Utility
    {
        public static string GetRandomString(int length)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var secret = new StringBuilder();
            while (length-- > 0)
            {
                secret.Append(alphabet[RandomNumberGenerator.GetInt32(alphabet.Length)]);
            }
            return secret.ToString();
        }
    }
}
