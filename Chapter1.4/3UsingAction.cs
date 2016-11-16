using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1._4
{
    class UsingAction
    {

        public static void Main()
        {

            Action<int, int> calc = (a, b) => { Console.WriteLine(a * b); }; //Action cannot return a value
            calc(5, 4);
            Console.ReadKey();
        }
    }
}
