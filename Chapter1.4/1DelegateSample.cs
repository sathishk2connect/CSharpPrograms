using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1._4
{
    class DelegateSample
    {
        public delegate int Calculate(int a, int b);

        public int Add(int a, int b) { return a + b; }

        public int Subract(int a, int b) { return a - b;  }

        public void UseDelegate()
        {
            Calculate calc = Add;
            calc += Subract;
            Console.WriteLine(calc(5, 6));
        }

        static void Main(string[] args)
        {
            DelegateSample obj = new DelegateSample();
            obj.UseDelegate();
            Console.ReadKey();
        }
    }
}
