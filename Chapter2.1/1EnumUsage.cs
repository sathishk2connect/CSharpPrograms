using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2._1
{
    class EnumUsage
    {
        public enum Days { MONDAY = 1 , TUESDAY = 2, WEDNESDAY = 3, THURSDAY = 4, FRIDAY = 5, SATURDAY = 6, SUNDAY = 0 }

        public static Dictionary<Days, string> DaysStr = new Dictionary<Days, string>() { 
                                                     {Days.MONDAY,"Monday"},
                                                     {Days.TUESDAY,"Tuesday"},
                                                     {Days.WEDNESDAY,"Wednesday"},
                                                     {Days.THURSDAY,"Thursday"},
                                                     {Days.FRIDAY,"Friday"},
                                                     {Days.SATURDAY,"Saturday"},
                                                     {Days.SUNDAY,"Sunday"}
                                                };

        static void Main(string[] args)
        {
             DateTime d = DateTime.Now;
             int[] priceOnDays = { 5, 10, 20, 11, 23 };
             Days today = (Days)d.DayOfWeek;
             Console.WriteLine("Today is " + DaysStr[today]);
             Console.ReadKey();
        }
    }
}
