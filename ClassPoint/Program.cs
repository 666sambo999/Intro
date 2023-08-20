using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPoint
{
    internal class Program
    {
        class Point
        {
            public double x; public double y;
            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public void print()
            {
                Console.WriteLine($" X= {x} \t Y = {y}");
            }
            public static Point operator +(Point left, Point richt)
            {
                return new Point(left.x + richt.x, left.y + richt.y);
            }
            public static Point operator -(Point left, Point richt)
            {
                return new Point(left.x - richt.x, left.y - richt.y);
            }
            public static Point operator *(Point left, Point richt)
            {
                return new Point(left.x * richt.x, left.y * richt.y);
            }
            public static Point operator /(Point left, Point richt)
            {
                return new Point(left.x / richt.x, left.y / richt.y);
            }
            public static Point operator --(Point left)
            {
                return new Point(--left.y, --left.x);
            }
            public static Point operator ++(Point richt)
            {
                return new Point(richt.y++, richt.x++);
            }
            public static bool operator <(Point left, Point richt)
            {
                return (left.x + left.y) < (richt.x + richt.y);
            }
            public static bool operator >(Point left, Point richt)
            {
                return (left.x + left.y) > (richt.x + richt.y);
            }
            public static bool operator ==(Point left, Point richt)
            {
                return (left.x + left.y) == (richt.x + richt.y);
            }
            public static bool operator !=(Point left, Point richt)
            {
                return (left.x + left.y) != (richt.x + richt.y);
            }


        }

        static void Main(string[] args)
        {
            Point1 point  = new Point1(5,3);
            //point.X = 2000;
            //point.Y = 3000;
            Console.WriteLine("X = " + point.X + "\tY = " + point.Y);

            point.print();
            Console.WriteLine(point);
            Console.WriteLine(((Object)2).ToString());

        }
    }
}
