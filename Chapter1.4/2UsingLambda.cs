using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1._4
{
    class UsingLambda
    {
        public delegate int Calculate(int x, int y);
        public static void Main()
        {
            Calculate calc = (a, b) =>
            {
                return a + b;
            };
            Console.WriteLine(calc(11, 6));
            Console.ReadKey();
        }
    }
}
