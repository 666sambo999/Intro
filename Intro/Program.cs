using Microsoft.Win32.SafeHandles;
using System.ComponentModel;
using System.Data;

namespace Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Привет дотнет";
            //Console.WriteLine("Hello World"); // вывод на экран,перенос на новую строку 

            //#region MyRegion
            //Console.Title = "Привет Andron";
            //Console.WriteLine("Hello World"); // вывод на экран,перенос на новую строку 
            //Console.BackgroundColor = ConsoleColor.Blue;// цвет 
            //Console.CursorLeft = 10;
            //Console.CursorTop = 11;
            //Console.Write("\t\t\t\t Привет дотнет\n");
            //Console.BackgroundColor = ConsoleColor.Black;

            //Console.Beep(40, 5000); // сигнал 

            //Console.Clear(); 
            //#endregion
            // Ctrl +k+d = убирает пробелы

            #region STRING_OPER
            /*
            Console.Write("Введите Ваше имя: ");
            string first_name = Console.ReadLine(); // Readline - возвращает строку 

            Console.Write("Введите Вашу Фамилию: ");
            string last_name = Console.ReadLine();

            Console.Write("Введите Ваш возраст: ");
            string s_age = Console.ReadLine();
            int age = Convert.ToInt32(s_age);// отвечает за конвертирование(преобразование) типов данных 

            Console.WriteLine("фамилия " + last_name + " Имя " + first_name + " возраст " + age + " лет."); // конкатенация строк = операция соединения нескольких текстовых строк в одну  
            Console.WriteLine(String.Format("Имя {0} фамилия {1} возраст {2} лет.", last_name, first_name, age)); // = это форматирование строк 
            Console.WriteLine($"Фамилия {last_name} имя {first_name} возраст {age} лет."); // интерполяция строк = это механизм объединения двух или более строк вместе
            */

            // все переменные - являются объектами 

            //last_name = first_name = "N/A";
            //Console.WriteLine(last_name + " " + first_name); 
            #endregion

            #region DATA_TYPES

            //Console.WriteLine(Boolean.TrueString); // логический тип данных
            //Console.WriteLine(Boolean.FalseString);
            //Console.WriteLine(sizeof(bool));
            //Console.Write("CHAR: ");
            //Console.WriteLine(sizeof(char));// Unicode (UTF-16)
            //Console.WriteLine(Convert.ToInt32(Char.MaxValue));
            //Console.WriteLine(Convert.ToInt32(Char.MinValue));

            //Console.WriteLine("------------------Numeric Types------------------------");
            //Console.WriteLine("SHORT: ");
            //short a = -2;
            //ushort b = 3;
            //Console.WriteLine(sizeof(short));
            //Console.WriteLine(short.MinValue + " " + short.MaxValue);

            //Console.WriteLine($"переменная типа short  занимает {sizeof(short)} байта памяти, и принимает значения в диапазоне  от {short.MinValue} до {short.MaxValue}");
            //Console.WriteLine($"переменная типа ushort  занимает {sizeof(ushort)} байта памяти, и принимает значения в диапазоне  от {ushort.MinValue} до {ushort.MaxValue}");
            //Console.WriteLine($"переменная типа char  занимает {sizeof(char)} байта памяти, и принимает значения в диапазоне  от {char.MinValue} до {char.MaxValue}");
            //Console.WriteLine($"переменная типа int  занимает {sizeof(int)} байта памяти, и принимает значения в диапазоне  от {int.MinValue} до {int.MaxValue}");
            //Console.WriteLine($"переменная типа double  занимает {sizeof(double)} байта памяти, и принимает значения в диапазоне  от {double.MinValue} до {double.MaxValue}");
            //Console.WriteLine($"переменная типа decimal  занимает {sizeof(decimal)} байта памяти, и принимает значения в диапазоне  от {decimal.MinValue} до {decimal.MaxValue}");
            //Console.WriteLine($"переменная типа long  занимает {sizeof(long)} байта памяти, и принимает значения в диапазоне  от {long.MinValue} до {long.MaxValue}");

            #endregion


            #region TYPES_CONVERSION

            //int a = 2;
            //uint b = 3;
            //a = (int)b;
            //Console.WriteLine(a);
            //double c = 5.2;
            //a = (int)c;
            //Console.WriteLine(a);
            //bool day = true;
            //Console.WriteLine(Convert.ToInt32(day));
            //double d = a;
            //Console.WriteLine(d);

            #endregion TYPES_CONVERSION


            #region LITHERALS
            /*
               Console.WriteLine((5l).GetType());
               Console.WriteLine((5.2).GetType());
               Console.WriteLine((5.2m).GetType());
               Console.WriteLine(5e-2);


               decimal dividend = Decimal.One;
               decimal divisor = 3;
               // The following displays 0.9999999999999999999999999999 to the console
               Console.WriteLine(Math.Round(dividend / divisor * divisor));
               */
            #endregion


            int i = 3;

            i = ++i + ++i;
            Console.ReadKey(i);
            Console.WriteLine(i);

        }
    }
}