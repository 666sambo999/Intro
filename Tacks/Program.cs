using System.Collections.Concurrent;
using Microsoft.Win32.SafeHandles;
using System.ComponentModel;
using System.Data;

namespace Tacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание №1; 
            // Console.WriteLine($"переменная типа short  занимает {sizeof(short)} байта памяти, и принимает значения в диапазоне  от {short.MinValue} до {short.MaxValue}");

            #region #1
            // Задание №2;
            //double money;
            //int rub, cop;
            //Console.Write("Введите сумму: ");
            //decimal money = Convert.ToDecimal(Console.ReadLine());
            ////Console.WriteLine(money);
            //int rub = (int)money;
            ////Console.WriteLine(rub);
            //int cop = (int)((money - rub) * 100);
            //Console.WriteLine($"{rub} рублей {cop} коп."); 
            #endregion


            #region #3
            // Задание №3;
            //Console.Write("Цена тетради(руб): ");
            //decimal a = Convert.ToDecimal(Console.ReadLine());

            //Console.Write("Количество тетрадей:");
            //decimal b = Convert.ToDecimal(Console.ReadLine());

            //Console.Write("Цена карандаша(руб):");
            //decimal c = Convert.ToDecimal(Console.ReadLine());

            //Console.Write("Количество карандашей:");
            //decimal d = Convert.ToDecimal(Console.ReadLine());

            //decimal money = (a * b + c * d);
            //Console.WriteLine($"{money} рублей "); 
            #endregion

            #region #4 
            // Заданиу %4;
            //Console.Write("Цена тетради(руб): ");
            //decimal a = Convert.ToDecimal(Console.ReadLine());

            //Console.Write("Цена обложки(руб): ");
            //decimal b = Convert.ToDecimal(Console.ReadLine());

            //Console.Write("Количество комплектов: ");
            //decimal c = Convert.ToDecimal(Console.ReadLine());

            //decimal money = (a * c) + (b * c);
            //Console.WriteLine($"{money} рублей "); 
            #endregion

            double S = 67;
            double fuel = 8.5; 
            double money = 7.6;

            decimal sum = (decimal) (((S+S)/ 100 * fuel)*money);
            Console.WriteLine($"{sum} рублей ");


        }
    }
}