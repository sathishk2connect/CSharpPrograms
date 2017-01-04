using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2._6
{

    class DisposeFromAnotherDemo
    {

        static void Main(){
             MemoryObj mObj = new MemoryObj();
             DisposingMemoryObject(mObj);
             Console.WriteLine("Object still alive");
             mObj.arr[1] = 20000;
             Console.ReadKey();
        }

         private static void DisposingMemoryObject(MemoryObj mObj)
         {
             mObj.arr[0] = 10000;
         }
        
    }
}
