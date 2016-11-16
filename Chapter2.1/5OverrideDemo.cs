using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2._1
{

    public class Baseclass
    {
        public virtual void foo()
        {
            Console.WriteLine("Base!!!!");
        }

        public void callFoo()
        {
            foo();
        }

    }

    public class ChildClass : Baseclass
    {
        public override void foo()
        {
            Console.WriteLine("Child!!!!");
        }

    }

    class OverrideDemo
    {
        static void Main()
        {
            ChildClass cc = new ChildClass();
            cc.callFoo(); 
        }

    }
}
