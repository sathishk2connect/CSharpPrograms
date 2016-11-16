using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._2
{
    class HashingSHA256
    {
        public static void Main()
        {
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            SHA256 sha256 = SHA256.Create();

            string data = "A Paragraph of Text";
            byte[] hashA = sha256.ComputeHash(byteConverter.GetBytes(data));

            string data1 = "A Paragraph of Modified Text";
            byte[] hashB = sha256.ComputeHash(byteConverter.GetBytes(data1));

            string data2 = "A Paragraph of Text";
            byte[] hashC = sha256.ComputeHash(byteConverter.GetBytes(data2));

            Console.WriteLine(hashA.SequenceEqual(hashB));
            Console.WriteLine(hashA.SequenceEqual(hashC));
            Console.ReadKey();

        }
    }
}
