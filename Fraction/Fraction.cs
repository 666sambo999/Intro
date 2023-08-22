using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Fraction
    {
        //int integer;
        //int numerator;
        int denominator;
        public int Integer { get; set; }
        public int Numerator { get; set; }  
        public int Denominator 
        { 
            get { return denominator; }
            set
            {
                if (value == 0) value = 1;
                denominator = value;
            }
                
        }
        public Fraction() 
        {
            //Integer = 0;
            //Numerator = 0;
            Denominator = 1;
        
        }
        public Fraction (int integer)
        {
            Integer = integer;
        }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public Fraction(int integer, int numerator,int denominator)
        {
            Integer = integer;
            Numerator = numerator;
            Denominator = denominator;
        }
        public void Print()
        {
            if (Integer != 0) Console.Write(Integer);
            if (Numerator !=0)
            {
                if (Integer != 0) Console.Write("(");
                Console.Write( Numerator + "/" + Denominator);
                if (Integer != 0) Console.Write(")");
            }
            else if (Integer == 0) Console.Write(0);
            Console.WriteLine();
        }
        public override string ToString()
        {
            //return $"{(Integer !=0 ? Integer.ToString():"")}{(Integer !=0? "(":"")}{(Numenator !=0?$" }
            string print;
            if (Integer != 0) print = Integer.ToString();
            else print = "0";
            if (Numerator != 0)
            {
                if (Integer != 0) print += "(";
                print += (Numerator + "/" + Denominator);
                if (Integer != 0) print += ")";
            }
            else if (Integer == 0) print = "0";
            return print;

        }
        public static Fraction operator +(Fraction left, Fraction right) 
        { 
            return new Fraction (left.Numerator*right.Denominator + right.Numerator*left.Denominator, left.Denominator*right.Denominator);  
        }
        public static Fraction operator - (Fraction left, Fraction right)
        {
            return new Fraction(left.Numerator * right.Denominator - right.Numerator * left.Denominator, left.Denominator * right.Denominator);
        }
        public static Fraction operator *(Fraction left, Fraction right)
        {
            return new Fraction(left.Numerator*right.Numerator,left.Denominator*right.Denominator);
        }
        public static Fraction operator /(Fraction left, Fraction right)
        {
           return new Fraction(left.Numerator * right.Denominator, left.Denominator * right.Numerator);
        }
        public static bool operator ==(Fraction left, Fraction right)
        {
            return left == right;
        }
        public static bool operator !=(Fraction left, Fraction right)
        {
            return left != right;
        }
        public static bool operator >(Fraction left, Fraction right)
        {
            return !left.Equals(right);
        }
        public static bool operator <(Fraction left, Fraction right)
        {
            return (left.Numerator < right.Numerator);
        }
    }
}
