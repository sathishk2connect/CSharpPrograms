using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Chapter1
{
    class Program4
    {
        public static void Main()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from threadpool");
            });
            ThreadPool.QueueUserWorkItem((s) =>
            {
                for (int i = 0; i < 10; i++)
                    Console.WriteLine(i);
            });
            Console.ReadLine();
        }
    }
}
