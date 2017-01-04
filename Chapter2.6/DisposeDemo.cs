using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2._6
{
    class MemoryObj:IDisposable
    {
        public int[] arr = new int[100000];

        public void Dispose()
        {
            Console.WriteLine("Object Disposed");
            arr = null;
        }

       ~MemoryObj()
        {
            Console.WriteLine("Object Desctructor");
        }
    }

    class DisposeDemo
    {
        static void Main(string[] args)
        {
            using (MemoryObj obj = new MemoryObj())
            {
                obj.arr[0] = 1000;
                System.GC.SuppressFinalize(obj);
            }
            GC.Collect();
            
            Console.ReadKey();
        }
    }
}
