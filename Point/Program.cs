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
            public static int count;

            static Point ()
            {
                count = -1;
            }
            public Point (double x , double y)
            {
                this.x = x; 
                this.y = y;
            }
            public void print ()
            {
                Console.WriteLine($" X= {x} \t Y = {y}" );
            }
            public double distance(Point other)
            {
                //double x_distance = this.x - other.x;
                //double y_distance = this.y - other.y;
                //double distance = Math.Sqrt(x_distance* x_distance + y_distance* y_distance);       
                //return distance;
                return Math.Sqrt(Math.Pow(this.x-other.x,2)+Math.Pow(this.y-other.y,2));        
                //класс Math - содержит набор статичестких методов, реаизующие математич функции 
            }
            public static double distance (Point left, Point right) 
            { 
                return left.distance(right);
            }

        }
        
        // Heap 
        static void Main(string[] args)
        {
            Console.WriteLine($" Количество точек: {Point.count}");
            //Point A;
            //A.x = 2;
            //A.y = 3;
            //A.print();
            //Point B = new Point(8, 9);
            //B.print();

            Console.WriteLine($"Расстояние от точки А до точки В: {A.distance(B)}");
            Console.WriteLine($"Расстояние от точки B до точки A: {B.distance(A)}");
            Console.WriteLine($" Расстояние между точками *А* и *Б* {Point.distance(A,B)}");
            Console.WriteLine($" Расстояние между точками *Б* и *А* {Point.distance(B,A)}");

            Console.WriteLine($" Расстояние между точками *A* и *B*: {Point.distance(new Point(22, 33), new Point(77, 88))}"); ;
            Console.WriteLine($" Расстояние между точками *b* и *a*: {new Point(88, 66).distance(new Point(22, 33))}"); 

        }
    }
}
