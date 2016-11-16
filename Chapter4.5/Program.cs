using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Chapter4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int> { 8, 5, 14, 10, 17 , 39, 15, 20, 25, 32 };
            List<int> subList = new List<int> { 5, 25, 67, 39, 14, 40 }; 
            //IEnumerable<int> oddNum = from d in intList where d % 2 != 0 orderby d descending select d;
            IEnumerable<int> overlapNum = from d in intList join s in subList on 1 equals 1 where d != s orderby d descending select d;
            Console.WriteLine(string.Join(",", overlapNum.Distinct().ToArray()));
            Console.ReadKey();
        }
    }
}
