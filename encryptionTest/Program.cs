using System;
using System.Security.Cryptography;
using System.Text;

namespace encryptionTest
{
    class Program
    {
        public static string Encrypt(string input, string key)
        {
            byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        static string MD5Encrypt(string vrednost)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(vrednost));
                return Convert.ToBase64String(data);
            }
        }
        static string RC4(string input, string key)
        {
            StringBuilder result = new StringBuilder();
            int x, y, j = 0;
            int[] box = new int[256];
            for (int i = 0; i < 256; i++)
                box[i] = i;
            for (int i = 0; i < 256; i++)
            {
                j = (key[i % key.Length] + box[i] + j) % 256;
                x = box[i];
                box[i] = box[j];
                box[j] = x;
            }
            for (int i = 0; i < input.Length; i++)
            {
                y = i % 256;
                j = (box[y] + j) % 256;
                x = box[y];
                box[y] = box[j];
                box[j] = x;
                result.Append((char)(input[i] ^ box[(box[y] + box[j]) % 256]));
            }
            return result.ToString();
        }
      public static  void enkriptijaNiza(string[] inputZaSifrovanje)
        {
            Console.Write("MD5 i RC4 za niz:");
            foreach (var item in inputZaSifrovanje)
            {
                Console.Write(item);
            }
            Console.WriteLine("");
            foreach (string item in inputZaSifrovanje)
            {
                Console.WriteLine("Vaš MD5 Encryption(no Salt): " + MD5Encrypt(item));
                string rc4text = RC4(item, "123");

                Console.WriteLine("RC4 Encryption: " + rc4text);
                Console.WriteLine("RC4 Decryption: " + RC4(rc4text, "123"));
            }
        }


        static void Main(string[] args)
        {
            //string[] inputZaSifrovanje = { "zovem", "se", "zoran" };
            //enkriptijaNiza(inputZaSifrovanje);

            Console.WriteLine("Vaš MD5 Encryption(no Salt): " + MD5Encrypt("peric123"));
            Console.WriteLine("Vaš MD5 Encryption(no Salt): " + MD5Encrypt(MD5Encrypt("peric123")));

            Console.WriteLine("RC4 Encryption: " + RC4("peric123", "123"));
            Console.WriteLine("RC4 Decryption: " + RC4(RC4("peric123", "123"), "123"));

        }
    }
}
