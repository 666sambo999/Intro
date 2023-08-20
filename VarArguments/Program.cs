using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarArguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сумма значений: " + Sum(new int[] { 1, 2, 3, 4, 5, }));
        }
        static int Sum(int[]values) // классы и методы всегда с большой буквы
        {
            int sum = 0;
            for (int i =0;  i < values.Length; i++) 
            {
                sum += values[i];
            }
            return sum;
        }
    }
}
