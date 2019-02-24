using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odnomer_mas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Одномерный массив";
            //Создаем одномерный массив

            int[] a = new int[1000];
            int s;

            s = 0;

            //a[0] = 3;
            //a[1] = 6;
            //a[2] = 14;
            //a[3] = 17;
            //a[4] = 21;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Задайте элемент № " + i);

            //    a[i] = int.Parse(Console.ReadLine());

            //    s += a[i];
            //}

            //Console.WriteLine("Результирующий массив: \n");



            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Элемент № " + i + " " + a[i] + " ");
            //}

            //Console.WriteLine("Сумма элементов: " + s);

            //Console.ReadKey();

            Console.WriteLine("Задайте массив: \n");

            int i = 0;

            do
            {
                Console.WriteLine("Введите эл. № " + i);
                a[i] = int.Parse(Console.ReadLine());
                s += a[i];
                i++;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("\n");

            for ( int j = 0; j < i; j++)
            {
                Console.WriteLine("Элемент № " + j + " " + a[j]);
            }

            Console.WriteLine("\n Сумма элементов: " + s);

            Console.ReadKey();
        
        }
    }
}
