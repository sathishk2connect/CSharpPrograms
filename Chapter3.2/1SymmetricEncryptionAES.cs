using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._2
{
    class SymmetricEncryption
    {

        public static void EncyrptSomeText()
        {
            string original = "My Secret Data";

            using (SymmetricAlgorithm sa = new AesManaged())
            {
                byte[] encypted = Encrypt(sa, original);
                string decrypted = Decrypt(sa, encypted);
                Console.WriteLine(decrypted);
                Console.ReadKey();
            }
        }

        private static string Decrypt(SymmetricAlgorithm sa, byte[] encypted)
        {
            ICryptoTransform decryptor = sa.CreateDecryptor(sa.Key, sa.IV);
            using (MemoryStream msDecrypt = new MemoryStream(encypted))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }

        private static byte[] Encrypt(SymmetricAlgorithm sa, string original)
        {
            ICryptoTransform encrypter = sa.CreateEncryptor(sa.Key, sa.IV);
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encrypter, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt)){
                        swEncrypt.Write(original);
                    }
                  return msEncrypt.ToArray();
                }
            }
        }

        static void Main(string[] args)
        {
            EncyrptSomeText();
        }
    }
}
