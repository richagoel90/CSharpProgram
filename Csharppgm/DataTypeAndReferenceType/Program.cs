using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeAndReferenceType
{
    public class ABC
    {
        public int X { get; set; }

        public int Y { get; set; }

        public ABC(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            ABC r = new ABC(1, 2);

            Console.WriteLine("X={0}    Y={1}", r.X, r.Y);

            Change(r);

            Console.WriteLine("X={0}    Y={1}", r.X, r.Y);

            ABC g = new ABC(1, 2);

            Console.WriteLine("X={0}    Y={1}", g.X, g.Y);

            ChangeObject(g);

            Console.WriteLine("X={0}    Y={1}", g.X, g.Y);



            ABC m = new ABC(1, 2);

            Console.WriteLine("X={0}    Y={1}", m.X, m.Y);

            ChangeObject(ref m);

            Console.WriteLine("X={0}    Y={1}", m.X, m.Y);
        }

        public static void Change(ABC p)
        {
            p.X = 100;
            p.Y = 200;
        }

        public static void ChangeObject(ABC p)
        {
            p = new ABC(100, 200);
        }

        public static void ChangeObject(ref ABC p)
        {
            p = new ABC(100, 200);
        }
    }
}
