using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    class Program5
    {
        public static void Main()
        {
           /*
            
            Task t = Task.Run(() =>
                {
                    for (int i = 0; i < 100; i++)
                    {
                        Console.WriteLine(i);
                    }
                });
            t.Wait();
            Console.ReadKey();
            * 
            * */

            Task<int> t = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            }
            );
            Console.WriteLine(t.Result);
            Console.ReadKey();
          }
       
    }
}
