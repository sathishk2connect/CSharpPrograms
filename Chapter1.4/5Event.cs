using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1._4
{

    public class Pub
    {
        public event EventHandler OnChange = delegate { };
        public void Raise()
        {
            var exceptions = new List<Exception>();

            foreach (Delegate handler in OnChange.GetInvocationList())
            {
                try
                {
                    handler.DynamicInvoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                }
            }

            if (exceptions.Any())
            {
                throw new AggregateException(exceptions);
            }
        }
    }
    class Event
    {
        public void CreateAndRaise()
        {
            Pub p = new Pub();
            p.OnChange += (sender, e) => Console.WriteLine("Subscriber 1 Called");
            p.OnChange += (sender, e) => { throw new Exception("Subscriber 2 Has Exception"); };
            p.OnChange += (sender, e) => Console.WriteLine("Subscriber 3 Called");

            try
            {
                p.Raise();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(String.Join("\n",ex.InnerExceptions.Select(e => e.InnerException.Message).ToArray()));
            }

        }

        public static void Main()
        {
            Event ob = new Event();
            ob.CreateAndRaise();
            Console.ReadKey();
        }
    }
}
