using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2._1
{
    /* Struct cannot contain parameterless constructors */

    public struct Point 
    {
        public int x;
        public int y;

        public Point(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }

        public static Point operator +(Point f, Point s)
        {
            Point result = new Point(f.x + s.x, f.y + s.y);
            return result;
        }

        public static Point operator -(Point f, Point s)
        {
            Point result = new Point(f.x - s.x, f.y - s.y);
            return result;
        }

        public override string ToString()
        {
            return "( " + this.x + " , " + this.y + " )";
        }
    }

    class StructUsage
    {
        public static void Main()
        {
            Point A = new Point(5, 10);
            Point B = new Point(8, -3);
            Point C = A - B;
            Point copy = A;
            copy.x = 10;
            Console.WriteLine(A);
            Console.ReadKey();
        }
    }
}
