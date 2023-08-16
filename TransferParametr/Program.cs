using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TransferParametr
{
    internal class Program
    {
       static void Input (out int a,out int b)
        {
            Console.WriteLine($" Введите переменную а: ");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Введите переменную в: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        static void Exchange(ref int a, ref int b)
        {
            int buffer = a;
            a = b;
            b = buffer;
        }


        static void Main(string[] args)
        {
            int a, b;
            Input (out a, out b);
            Console.WriteLine($" {a} \t {b}");
            Exchange(ref a, ref b);
            Console.WriteLine($" {a} \t {b}");



        }
    }
}
