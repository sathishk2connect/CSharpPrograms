using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chapter2._7
{
    class StringFunctions
    {
        static void Main()
        {
           
            /*string sampleValue = "1 2     3      4                 5";
            string pattern = "\\s+";
            Regex rgx = new Regex(pattern);
            Console.WriteLine(rgx.Replace(sampleValue, ", "));
            Console.ReadLine();
            */
            string s1 = " abce";
            string s2 = s1.Insert(3, "d");
            Console.WriteLine(s2);
            Console.ReadLine();
        }
    }
}
