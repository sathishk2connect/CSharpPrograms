using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._5
{
    class EventLogDemo
    {
        static void Main()
        {

                 if (!EventLog.SourceExists("MySource"))
                {
                    EventLog.CreateEventSource("MySource", "MyNewLog");
                    Console.WriteLine("CreatedEventSource");
                    Console.WriteLine("Please restart application");
                    Console.ReadKey();
                    return;
                }
                EventLog myLog = new EventLog();
                myLog.Source = "MySource";
                myLog.WriteEntry("Log event!");

            EventLog log = new EventLog("MyNewLog");
            Console.WriteLine("Total entries: " + log.Entries.Count);
            EventLogEntry last = log.Entries[log.Entries.Count - 1];
            Console.WriteLine("Index: " + last.Index);
            Console.WriteLine("Source: " + last.Source);
            Console.WriteLine("Type: " + last.EntryType);
            Console.WriteLine("Time: " + last.TimeWritten);
            Console.WriteLine("Message: " + last.Message);
            Console.ReadKey();
        }
    }
}
