using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._5
{
    class CreatePCDemo
    {
        static void Main()
        {
            if (CreatePerformanceCounters())
            {
                Console.WriteLine("Created Peformance Counters");
                Console.WriteLine("Please restart the application");
                Console.ReadKey();
                return;
            }
            var totalOperationsCounter = new PerformanceCounter("MyCategory", "# operations executed", "", false);
            var operationPerSecondCounter = new PerformanceCounter("MyCategory", "# operations per second", "", false);

            totalOperationsCounter.Increment();
            operationPerSecondCounter.Increment();
        }

        private static bool CreatePerformanceCounters()
        {
            if (!PerformanceCounterCategory.Exists("MyCategory"))
            {
                CounterCreationDataCollection counters = new CounterCreationDataCollection
                {
                    new CounterCreationData("# operations executed","Total number of operations executed",PerformanceCounterType.NumberOfItems32),
                    new CounterCreationData("# operations / sec","Number of operations executed per second",PerformanceCounterType.RateOfCountsPerSecond32)
                };
                PerformanceCounterCategory.Create("MyCategory", "Sample Category for Project",PerformanceCounterCategoryType.SingleInstance, counters);
                return true;
            }
            return false;
        }
    }
}
