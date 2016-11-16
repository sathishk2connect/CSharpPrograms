using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Chapter1
{
    class Program8
    {
        public static async Task<string> GetStringAsync()
        {
            Task<string> t = Task.Run(() => { Thread.Sleep(2000); return "Wake up"; });
            return await t;
        }

        public static async Task<string> GetStringValue()
        {
            string result = await GetStringAsync();
            return result;
        }

        public static void Main()
        {
            string s = GetStringValue().Result;
            Console.WriteLine(s);
            Console.Read();
        }

    }
}
