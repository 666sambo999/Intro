using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // type[] name = new type [size]; -  объявдение массива
            // type[] name = new type [size] {init_valyes};


            Console.Write("Введите размер массива:");
            int n = Convert.ToInt32(Console.ReadLine());

            //int[] arr = new int[] { 5, 6, 7, 8, 10 };
            int[] arr = new int[n];
            // заполнения массива случайными числами 
            // 1) создаем объект класса Random 
            //Random random = new Random(0);// уникальное число одиниковые 
            Random random = new Random(); 
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(30, 300);
            }
            // Вывод массива на экран: 
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
            // Сумма 
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}

            // Средне-арифметическое 
            //int AVG = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    AVG = sum / n;
            //}
            //Console.WriteLine(AVG);

            // Минимальное 

            //for (int i =0; i<arr.Length; i++)
            //{
            //    if (arr[i] > int.MinValue) arr[i] = int.MaxValue;
            //}
            //Console.WriteLine(arr);

            
            Console.WriteLine($" Сумма элементов массива: {arr.Sum()}");
            Console.WriteLine($" Средне-арифметическое значение элементов: {arr.Average()}");
            Console.WriteLine($" Минимальное значение элемента: {arr.Min()}");
            Console.WriteLine($" Максимальное значение элемента: {arr.Max()}");

            Array.Sort(arr);
            // сортировка массива 
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

            arr = arr.Concat(new int[] { 100 }).ToArray();
            foreach (int i in arr) { Console.Write(i + "\t");} Console.WriteLine();

        }
    }
}
