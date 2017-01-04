using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Tracing;
using System.Diagnostics;

namespace Chapter3._5
{
    class DebugTraceDemo
    {
        static void Main(string[] args)
        {

            Debug.Assert(true);
            Debug.WriteLine("Debug related Information");


            TraceSource traceSource = new TraceSource("myTraceSource",SourceLevels.Critical);
            traceSource.TraceInformation("Tracing application..");
            traceSource.TraceEvent(TraceEventType.Critical, 0, "Critical trace");
            traceSource.TraceData(TraceEventType.Warning, 1, new object[] { "a", "b", "c" });
            traceSource.Flush();
            traceSource.Close();
        }
    }
}
