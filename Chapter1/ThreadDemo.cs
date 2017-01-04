using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Chapter1
{
    class ThreadDemo
    {
        static void Main()
        {
            Thread t = new Thread(WriteY);
            t.Start();
            for (int i = 0; i < 1000; i++) Console.Write("x");
            
            Console.ReadKey();
        }

        static void WriteY()
        {
            for (int i = 0; i < 1000; i++) Console.Write("y");
            
        }
    }
}
