using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2._1
{
    interface IA
    {
        void Impl();
    }

    interface IB
    {
        void Impl();
    }
    class MultipleInheritance: IA,IB
    {
        void IA.Impl()
        {
            Console.WriteLine("Implementation of Default IA Method");
        }

        void IB.Impl()
        {
            Console.WriteLine("Implementation of IB Method");
        }

        static void Main()
        {
            IA mia = new MultipleInheritance();
            IB mib = new MultipleInheritance();
            MultipleInheritance mi = new MultipleInheritance();
            mia.Impl();
            mib.Impl();
            //mi.Impl();
            Console.ReadKey();
        }
    }
}
