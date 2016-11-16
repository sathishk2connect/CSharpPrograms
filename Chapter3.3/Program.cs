using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Diagnostics;

namespace Chapter3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("Starting application");
            Console.WriteLine("Hello Wold Console Program");
            string env = ConfigurationManager.AppSettings.Get("ENV");
            Console.WriteLine("Current Environment: " + env);
            Console.ReadKey();
        }
    }
}
