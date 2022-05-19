using System.Security.Cryptography;
using System.Text;

namespace Utils
{
    public class HashUtility
    {
        private static string ByteToString(byte[] buff)
        {
            string sbinary = "";
            for (int i = 0; i < buff.Length; i++)
                sbinary += buff[i].ToString("x2"); /* hex format */
            return sbinary;
        }

        private static String GetSalt(int length)
        {
            var salt = new Byte[4];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
                String chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var random = new Random(BitConverter.ToInt32(salt, 0));
                return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            }
        }

        public static string ComputeHash(string plaintext, string salt)
        {
            if (plaintext.Length == 0)
            {
                throw new Exception("plaintext cannot be empty or null.");
            }
            if (salt == null)
            {
                salt = GetSalt(8);
            }
            var hash64 = GetHash(plaintext, salt);

            return salt + hash64;
        }

        private static String GetHash(String text, String key)
        {
            // change according to your needs, an UTF8Encoding
            // could be more suitable in certain situations
            ASCIIEncoding encoding = new ASCIIEncoding();

            Byte[] textBytes = encoding.GetBytes(text);
            Byte[] keyBytes = encoding.GetBytes(key);

            Byte[] hashBytes;

            using (HMACSHA1 hasher = new HMACSHA1(keyBytes))
                hashBytes = hasher.ComputeHash(textBytes);

            string hash = ByteToString(hashBytes);

            //Now the easy part, convert it to base64
            var bytesTo64 = Encoding.UTF8.GetBytes(hash);
            String hash64 = Convert.ToBase64String(bytesTo64);

            return hash64;
        }
    }
}
