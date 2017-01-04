using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4._3
{
    class LinqSort
    {

        public static void Main()
        {
            int[] arr = { 4, 9, 10, 2, 9, 3 };
            List<int> arrList = new List<int>() { 10, 3, 9, 5, 11, 2 };
            arrList.Sort();
            arrList.Reverse();
            Console.WriteLine(string.Join(",",arrList));
            Console.WriteLine(string.Join(",",arr.OrderByDescending(a=>a).ToArray()));
            Console.Read();
        }
    }
}
