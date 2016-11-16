using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4._3
{
    public static class IntegerExtensions
    {
        public static int Multiply(this int x, int y)
        {
            return x * y;
        }
    }

    public static class StringExtensions
    {
        public static string Currency(this string s)
        {
            return "$" + s;
        }
    }

    class ExtensionMethodDemo
    {
           public static void Main()
            {
                int x = 2;
                string c = "100.00";
                Console.WriteLine(x.Multiply(3));
                Console.WriteLine(c.Currency());
                Console.ReadKey();
            }
    }
}
