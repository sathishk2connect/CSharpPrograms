using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1._2
{
    class Person
    {
        public string Name { get; set; }
    }
    class DynamicDemo
    {
        static void Main()
        {

            dynamic val = new Person { Name = "Ravi" };
            Console.WriteLine(val.Age);
            Console.ReadKey();

        }
    }
}
