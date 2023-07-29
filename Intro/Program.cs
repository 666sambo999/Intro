using System.Data;

namespace Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Title = "Привет дотнет";
            //Console.WriteLine("Hello World"); // вывод на экран,перенос на новую строку 

            #region MyRegion
            Console.Title = "Привет Andron";
            Console.WriteLine("Hello World"); // вывод на экран,перенос на новую строку 
            Console.BackgroundColor = ConsoleColor.Blue;// цвет 
            Console.CursorLeft = 10;
            Console.CursorTop = 11;
            Console.Write("\t\t\t\t Привет дотнет\n");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Beep(40, 5000); // сигнал 

            Console.Clear(); 
            #endregion
            // Ctrl +k+d = убирает пробелы


        }
    }
}