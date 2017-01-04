using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._5
{
    class TraceListenerDemo
    {
        public static void Main()
        {
            Stream outputFile = File.Create("traceFile.txt");
            TextWriterTraceListener textListener = new TextWriterTraceListener(outputFile);

            TraceSource ts = new TraceSource("TracingMyApp", SourceLevels.All);
            ts.Listeners.Clear();
            ts.Listeners.Add(textListener);

            ts.TraceInformation("Trace output");

            ts.Flush();
            ts.Close();
        }

    }
}
