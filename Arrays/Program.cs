using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // type[] name = new type [size]; -  объявдение массива
            // type[] name = new type [size] {init_valyes};


            #region Arrays
            // Console.Write("введите размер массива:");
            // int n = Convert.ToInt32(Console.ReadLine());

            // int[] arr = new int[] { 5, 6, 7, 8, 10 };
            // //int[] arr = new int[n];
            // //заполнения массива случайными числами
            // // 1) создаем объект класса random
            // Random random = new Random(0);// уникальное число одиниковые 
            // //Random random = new Random();
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     arr[i] = random.Next(30, 300);
            // }
            //// вывод массива на экран: 
            //  for (int i = 0; i < arr.Length; i++)
            // {
            //     Console.Write(arr[i] + "\t");
            // }
            // Console.WriteLine();
            // //сумма
            // int sum = 0;
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     sum += arr[i];
            // }

            // //средне - арифметическое
            // int avg = 0;
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     avg = sum / n;
            // }
            // Console.WriteLine(avg);

            // //минимальное

            // for (int i = 0; i < arr.Length; i++)
            // {
            //     if (arr[i] > int.MinValue) arr[i] = int.MaxValue;
            // }
            // Console.WriteLine(arr);


            // Console.WriteLine($" сумма элементов массива: {arr.Sum()}");
            // Console.WriteLine($" средне-арифметическое значение элементов: {arr.Average()}");
            // Console.WriteLine($" минимальное значение элемента: {arr.Min()}");
            // Console.WriteLine($" максимальное значение элемента: {arr.Max()}");

            // Array.Sort(arr);
            // // сортировка массива 
            // foreach (int i in arr)
            // {
            //     Console.Write(i + "\t");
            // }
            // Console.WriteLine();

            // arr = arr.Concat(new int[] { 100 }).ToArray();
            // foreach (int i in arr) { Console.Write(i + "\t"); }
            // Console.WriteLine();
            #endregion



            #region Arrays2
            //// Двумерные массивы 

            ////Console.Write("Введите количество строк: ");
            ////int rows = Convert.ToInt32(Console.ReadLine());
            ////Console.Write("Введите количество элементов строк: ");
            ////int cols = Convert.ToInt32(Console.ReadLine()); 
            ////int[,] i_arr_2 = new int[rows, cols];
            //// 2 вариант 
            //int[,] i_arr_2 = new int[,]
            //{
            //       {1,2,3 },
            //       {4,5,6 },
            //       {7,8,9},
            //};

            //Console.WriteLine(i_arr_2.Length);
            //Console.WriteLine(i_arr_2.Rank);
            //Console.WriteLine(i_arr_2.GetLength(0));
            //Console.WriteLine(i_arr_2.GetLength(1));
            //Random rand = new Random(0);
            ////for (int i = 0; i < i_arr_2.GetLength(0); i++)
            ////{
            ////    for (int j = 0; j < i_arr_2.GetLength(1); j++)
            ////    {
            ////        i_arr_2[i, j] = rand.Next(100);
            ////    }
            ////}

            //for (int i = 0; i < i_arr_2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < i_arr_2.GetLength(1); j++)
            //    {
            //        Console.Write(i_arr_2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //// Сумма элементов 
            //int sum = 0;
            //for (int i = 0; i < i_arr_2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < i_arr_2.GetLength(1); j++)
            //    {
            //        sum += i_arr_2[i, j];
            //    }
            //}
            //Console.WriteLine($"Сумма элементов массива: {sum}");
            //foreach (int i in i_arr_2)
            //{
            //    Console.Write(i + "\t");
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Сумма элементов массива {i_arr_2.Cast<int>().Sum()}");
            //Console.WriteLine($"Средне-арифметическое значение элементов массива {i_arr_2.Cast<int>().Average()}");
            //Console.WriteLine($"Минимальное значение элементов массива {i_arr_2.Cast<int>().Min()}");
            //Console.WriteLine($"Максимальное значение элементов массива {i_arr_2.Cast<int>().Max()}");

            //// Коллекции в с# = контейнер в с++; 
            #endregion

            #region Ragged_Arrays

            // Рваные массивы 

            //Console.Write("Введите количество строк: ");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите количество элементов строк: ");
            //int cols = Convert.ToInt32(Console.ReadLine());
            //int[][] ragged_arr = new int[5][];  // объявляем массив указателей (ссылок)
            //ragged_arr[0] = new int[] { 1, 2, 3, 4, 5 };
            //ragged_arr[1] = new int[] { 5, 6, 7, 8, 9, };
            //ragged_arr[2] = new int[] { 10, 11, 12, 14, 18 };
            //ragged_arr[3] = new int[] { 17, 21, 29, 30, 94 };
            //ragged_arr[4] = new int[] { 34, 67, 8, 30, 0};

            //for (int i = 0; i < ragged_arr.Length; i++)
            //{
            //    ragged_arr[i] = new int[cols]; // одномерный массив 
            //}
            //Random rand = new Random(0);

            //for (int i = 0; i < ragged_arr.Length; i++)
            //{
            //    for (int j = 0; j < ragged_arr[i].Length; j++)
            //    {
            //        ragged_arr[i][j] = rand.Next(100);
            //    }
            //}

            //for (int i = 0; i < ragged_arr.Length; i++)
            //{
            //    for (int j = 0; j < ragged_arr[i].Length; j++)
            //    {
            //        Console.Write(ragged_arr[i][j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            // for 
            //foreach (int[] i in ragged_arr) // Итератор i перебирает массивы
            //{
            //    if (i != null)
            //    {
            //        foreach (int j in i)         // итератор j перебирает элементы массива 
            //        {
            //            Console.Write(j + "\t");
            //        }
            //        Console.WriteLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Пустая строка");
            //    }
            //}

            // Sum - сумма
            //int sum = 0;
            //int count = 0;

            //foreach (int[] i in ragged_arr)
            //{
            //    if (i != null)
            //    {
            //        sum += i.Sum();
            //        count += i.Length;

            //    }
            //}
            //Console.WriteLine($"Сумма элементов массива: {sum}");
            //Console.WriteLine($"Средне-арифметическое элементов массива: {(double)sum / count}");
            //int Min = 0;
            //int Max = 0;
            //for (int i = 0; i < ragged_arr.Length; i++)
            //{
            //    if (ragged_arr[i] != null)
            //    {
            //        for (int j = 0; j < ragged_arr[i].Length; j++)
            //        {
            //            if (Max < ragged_arr[i][j]) Max = ragged_arr[i][j];
            //            if (Min > ragged_arr[i][j]) Min = ragged_arr[i][j];
            //        }
            //    }

            //}
            //Console.WriteLine($"Минимальное значение элементов массива: {Min}");
            //Console.WriteLine($"Максимальное значение элементов массива: {Max}");
            #endregion


            // перечисления 

            Season season = Season.Winter;
            Console.WriteLine(season);

            System.Enum.GetName(typeof(Week), Week.Monday);
            foreach(Week i in System.Enum.GetValues(typeof(Week)).Cast<Week>())
            {
                Console.WriteLine(i);  
            }
            //Week day = Week.Monday;
            //Console.WriteLine( day );

            string [] dayName = Enum.GetNames(typeof(Week));
            int[] dayNumbers = (int[])Enum.GetValues(typeof(Week));
            for(int i=0; i< dayNumbers.Length;i++)
            {
                Console.WriteLine($"Name: {dayName[i]} \t = Value: {dayNumbers[i]}");
            }
            Console.WriteLine(delimeter);
            string[] distName = Enum.GetNames(typeof(DistanceFromSun));
            ulong[] distValue = (ulong[])Enum.GetValues(typeof(DistanceFromSun));
            for (int i =0; i< distName.Length; i++)
            {
                Console.WriteLine($"Name: {distName[i]} \t  = {distValue[i]}");
            }
            Console.WriteLine(delimeter);
            Console.WriteLine($" Type: {Enum.GetUnderlyingType(typeof(DistanceFromSun))}" );
            //  double  тоже самое, меняется тип данных 
        }

        const string delimeter = "\n----------------------------------\n"; 
        enum Season
        {
            Winter, Spring, Summer, Autumn
        };
        enum Week : uint
        {
            Sunday = 0,
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
        };
        enum DistanceFromSun : ulong
        { 
            Sun =0,
            Mercury = 579000000,
            Venus = 1082000000,
            Earth = 149600000,
            Mars = 227900000,
            Jupiter = 7783000000,
            Saturn = 1427000000,
            Uranus = 2870000000,
            Neptune = 4496000000,
            Pluto = 594600000
        }



    }
}
