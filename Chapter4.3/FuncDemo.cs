using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4._3
{
    class FuncDemo
    {
        static void Main(string[] args)
        {
            Func<double, double> twoDecimal = (t) => { return Math.Round(t, 2); };
            Console.WriteLine(twoDecimal(100.3242734));
            Console.ReadLine();
        }
    }
}
