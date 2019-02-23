using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tern_op
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Тернарный оператор";

            int a;
            bool b;

            Console.WriteLine("Введите число: ");
            a = int.Parse(Console.ReadLine());

            b = false;

            if (a % 3 == 0)
            {
                b = true;
            }

            Console.WriteLine(b ? (a + " Кратно 3") : (a + " Не кратно 3"));

            Console.ReadKey();

        }
    }
}
