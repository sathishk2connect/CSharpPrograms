using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    class Program
    {
        public static async void PrintData()
        {
            Task<string> result = DoCalculation();
            Console.WriteLine("Processing....");
            Console.ReadKey();
            string processedResult = await result;
            Console.WriteLine(result.Result);
        }

        public static Task<string> DoCalculation()
        {
            Console.WriteLine("Waiting for System input");
            System.Threading.Thread.Sleep(1000);
            return Task<string>.Factory.StartNew(() => "Success");
        }

        public static void zeroMoveToEnd(int[] array)
        {
            int end = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    while(array[end] == 0) end--;
                    array[i] = array[end];
                    array[end] = 0;
                    end--;
                }
                if (i >= end) break;
            }
        }

        static void Main(string[] args)
        {
           /* Task task = new Task(PrintData);
            task.Start();
            task.Wait(); */
            int[] array = { 10, 0, 7, 9, 4, 0, 0, 9, 45, 75, 0, 21, 0, 46 };
            zeroMoveToEnd(array);
            Console.WriteLine(string.Join(",", array));
            Console.ReadKey();
        }
    }
}
