using System.Collections.Concurrent;
using Microsoft.Win32.SafeHandles;
using System.ComponentModel;
using System.Data;
using System.Timers;

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


            #region #5 

            //double S = 67;
            //double fuel = 8.5;
            //double money = 7.6;

            //decimal sum = (decimal)(((S + S) / 100 * fuel) * money);

            //Console.WriteLine($"{sum} рублей ");

            #endregion

            #region №6
            // Задача №6;

            //Console.Write("Введите выражение: ");
            //string expression = Console.ReadLine();  // Читает строку с клавиатуры 
            //expression = expression.Replace('.', ','); // Replace - заменяет первый символ вторым символом.Те точку на запятую
            //String[] values = expression.Split(new char[] { '+', '-', '*', '/' }); // Метод Split - разделяет строку на подстроки по указанным разделителям
            // Split - принимает массив char  в котором есть разделители и возвращает массив строк (токенов)
            // Split не изменяет исходную строку 
            //for (int i = 0; i< values.Length; i++)
            //{
            //    Console.WriteLine(values[i]);
            //}

            //double a = Convert.ToDouble(values[0]);
            //double b = Convert.ToDouble(values[1]);
            // Метод Contains проверяет содержит ли исходная строка указанную подстроку  
            //if (expression.Contains("+")) Console.WriteLine($"{a} + {b}= {a + b}");
            //else if (expression.Contains("-")) Console.WriteLine($"{a}-{b}={a - b}");
            //else if (expression.Contains("*")) Console.WriteLine($"{a}*{b} = {a * b}");
            //else if (expression.Contains("/")) Console.WriteLine($"{a}/{b} = {a / b}");
            //Console.WriteLine(" No operation"); 
            #endregion

            // Задание №7

            #region Shooter
            //ConsoleKey key;
            //do
            //{
            //    key = Console.ReadKey(true).Key;

            //    switch (key)
            //    {
            //        case ConsoleKey.W: Console.WriteLine("Вперед"); break;
            //        case ConsoleKey.S: Console.WriteLine("Назад"); break;
            //        case ConsoleKey.A: Console.WriteLine("Влево"); break;
            //        case ConsoleKey.D: Console.WriteLine("Вправо"); break;
            //        case ConsoleKey.Spacebar: Console.WriteLine("Прыжок"); break;
            //        case ConsoleKey.Enter: Console.WriteLine("Огонь"); break;
            //        default: Console.WriteLine("Error"); break;
            //    }
            //    Console.Beep(60, 500);
            //} while (key != ConsoleKey.Escape); 
            #endregion


            // Задание №8 

            int x = 10;
            int y = 10;
            Console.CursorVisible = false;
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.W: y--; break;
                    case ConsoleKey.S: y++; break;
                   case ConsoleKey.A: x--; break;
                    case ConsoleKey.D: x++; break;
                    default: Console.Beep(); break;
                }
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(x, y);
                Console.WriteLine(" ");
                Console.BackgroundColor = ConsoleColor.Black;
            } while (key != ConsoleKey.Escape);



            //ConsoleKey key;
            //int x = 20, y = 20;
            //do
            //{
            //    key = Console.ReadKey(true).Key;
            //    Console.SetCursorPosition(x, y);
            //    switch (key)
            //    {
            //        case ConsoleKey.W: y--; break;
            //        case ConsoleKey.S: y++; break;
            //        case ConsoleKey.A: x--; break;
            //        case ConsoleKey.D: x++; break;
            //        default: Console.Beep(); break;
            //    }
            //    Console.BackgroundColor = ConsoleColor.Blue;
            //    Console.WriteLine(".");
            //    Console.BackgroundColor = ConsoleColor.Black;
            //    Console.Clear();
            //} while (key != ConsoleKey.Escape);





        }
    }
}