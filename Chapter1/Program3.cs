using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Chapter1
{
    class Program3
    {
        public static void Main()
        {
            bool stopped = false;
            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running ...");
                    Thread.Sleep(1000);
                }

            }));

            t.Start();
            Console.WriteLine("press any key to exit");
            Console.ReadKey();

            stopped = true;
            t.Join();
        }

    }
}
