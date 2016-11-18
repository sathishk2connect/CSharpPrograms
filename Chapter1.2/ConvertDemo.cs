using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1._2
{
    class ConvertDemo
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Int32.Parse(null));

            int value = Convert.ToInt32("42");
                value = int.Parse("42");
            bool success = int.TryParse(null, out value);
            Console.WriteLine(success);

            Console.ReadKey();
        }
    }
}
