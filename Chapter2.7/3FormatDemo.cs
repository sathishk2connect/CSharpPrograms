using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2._7
{
    
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }

        public string ToString(String format)
        {
            return FirstName + " " + LastName + " DOB: " + DOB.ToString("d", new CultureInfo(format));
        }
    }

    class FormatDemo
    {
        static void Main()
        {
            Person p = new Person();
            p.FirstName = "Rahul";
            p.LastName = "Vijay";
            p.DOB = DateTime.Now;
            Console.WriteLine(p.ToString("en-SG"));
            Console.ReadLine();
        }
    }
}
