using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4._3
{
    class Hometown
    {
        public string City { get; set; }
        public string State { get; set; }
    }

    class LinqOrderGroup
    {
        static void Main()
        {
            List<Hometown> hometowns = new List<Hometown>()
            {
            new Hometown() { City = "Philadelphia", State = "PA" },
            new Hometown() { City = "Ewing", State = "NJ" },
            new Hometown() { City = "Havertown", State = "PA" },
            new Hometown() { City = "Fort Washington", State = "PA" },
            new Hometown() { City = "Trenton", State = "NJ" }
            };

            var orderHometown = from h in hometowns
                                orderby h.City descending, h.State
                                select h;

            foreach(var e in orderHometown){
                Console.WriteLine(e.City + "  " + e.State);
            }

            //Group By States
            var groupHometown = from h in hometowns
                                group h by h.State into g
                                select new { g.Key, Cities = g.Select(c=> c.City).OrderBy(o => o).ToArray() };

            foreach (var e in groupHometown)
            {
                Console.WriteLine(e.Key + "  " + string.Join(",",e.Cities));
            }

            Console.ReadKey();
        }
    }
}
