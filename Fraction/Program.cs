using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction A = new Fraction();
            Console.WriteLine(A);
            A.Print();

            Fraction B = new Fraction(5);
            B.Print();

            Console.WriteLine(B);   
            Fraction C = new Fraction(1,2);
            C.Print();

            Fraction D = new Fraction(6,3,4);
            D.Print();
        
        
        
        }
        
    }
}
