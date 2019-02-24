using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Cont
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Операторы break и continue";

            //break

            int[] a = new int[10] { 2, 3, 7, 8, 1, 11, 9, 0, 4, 23 };
            bool b = false;
            int k = 0;
            int s = 0;


            Console.WriteLine("Исходный массив: ");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine("\nПроверка...");

            for (int i = 0; i < 10; i++)
            {
                if (a[i] % 3 == 0)
                {
                    b = true;
                    k = a[i];
                    break;
                }
            }

            Console.WriteLine(b ? ("Есть эл. кратный 3(" + k + ")") : ("Нет эл. кратного 3"));

            //continue

            for (int i = 0; i < 10; i++)
            {
                if (a[i] % 2  == 0)
                {
                    continue;
                }

                s += a[i]; 
            }

            Console.WriteLine("Сумма нечетных элементов: " + s);

            Console.ReadKey();
           
        }
    }
}
