using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    internal class Program
    {
        struct Point
        {
            public double x, y;
            public Point (double x , double y)
            {
                this.x = x; 
                this.y = y;
            }
            public void print ()
            {
                Console.WriteLine($" X= {x} \t Y = {y}" );
            }
        }

        // Heap 
        static void Main(string[] args)
        {
            Point A;
            A.x = 2;
            A.y = 3;
            A.print();
            Point B = new Point(8, 9);
            B.print();
        }
    }
}
