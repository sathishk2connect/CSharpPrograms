using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._5
{
    class PerformanceCounterDemo
    {
        static void Main()
        {
            Console.WriteLine("press esc key to exit...");
            using (PerformanceCounter pc = new PerformanceCounter("Memory", "Available Bytes"))
            {
                string text = "Available Memory...";
                Console.Write(text);
                do
                {
                    while (!Console.KeyAvailable)
                    {
                        Console.Write(pc.RawValue);
                        Console.SetCursorPosition(text.Length, Console.CursorTop);
                    }

                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }
        }
    }
}
