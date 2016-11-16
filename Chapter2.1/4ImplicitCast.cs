using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2._1
{
    class Identity
    {
        public int regNo;

        public static implicit operator Identity(int i)
        {
            Identity id = new Identity();
            id.regNo = i;
            return id;
        }

        public static implicit operator string(Identity i)
        {
            return i.regNo.ToString();
        }

    }

    class ImplicitCast
    {
        static void Main()
        {
            Identity i = 20934;
            string strRegNo = i;
            Console.WriteLine(strRegNo);
            Console.ReadKey();
        }
    }
}
