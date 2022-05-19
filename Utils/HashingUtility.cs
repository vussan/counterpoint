using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class HashingUtility
    {
        public static string ComputeHash(string plaintext, string salt)
        {
            if (salt == null)
                salt = Utility.GetRandomString(8);

            var password = plaintext + salt;
            return GetHash(password);
        }

        public static string GetHash(string password)
        {
            var crypt = SHA256.Create();
            var hash = new StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password), 0, Encoding.UTF8.GetByteCount(password));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }

            return hash.ToString();
        }
    }
}
