using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Калькулятор";

            double a, b;
            char c;

        L1:

            Console.WriteLine("Введите a");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Ведитие знак действия: ");
            c = char.Parse(Console.ReadLine());

            Console.WriteLine("Введите b");
            b = double.Parse(Console.ReadLine());
        
            switch (c)
            {
                case '+':

                    Console.WriteLine("Сумма: " + (a + b));

                    break;

                case '-':

                    Console.WriteLine("Разность: " + (a - b));

                    break;
                case '*':

                    Console.WriteLine("Произведение: " + (a * b));

                    break;
                case '/':

                    Console.WriteLine("Частное: " + (a / b));

                    break;
                default:

                    Console.WriteLine("Ошибка!");

                    break;
            }

            goto L1;

        }
    }
}
