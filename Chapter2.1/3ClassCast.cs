using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2._1
{
    class Person
    {
        public string FirstName;
        public string LastName;

        public Person()
        {
            FirstName = "";
            LastName = "";
        }

    }

    class Employee : Person
    {
        public int ID;
        Employee()
        {
            ID = 3;
        }
    }

    class ClassCast
    {
        static void Main()
        {
            Person p = new Person();
            Employee e = (Employee)p;
            Console.WriteLine(e.ID);
            Console.ReadKey();
        }
    }
}
