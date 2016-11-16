using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Chapter3._1
{

    public class Customer
    {

        [KeyAttribute]
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string FirstName { get; set; }

        [Required, MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        public string strDOB { get; set;  }

        [Required]
        public string DOB { get; set; }
    }

    public class EcommerceContext : DbContext
    {
        public IDbSet<Customer> Customers { get; set; }
    }


    class EntityValidation
    {
        static void Main(string[] args)
        {

            using (EcommerceContext ctx = new EcommerceContext())
            {
                if (!ctx.Database.Exists())
                {
                    ctx.Database.Initialize(true);
                }

                try
                {
                    Customer c = new Customer { FirstName = "Sathish", strDOB = "30-01-1988" };
                    ctx.Customers.Add(c);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
