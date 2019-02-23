using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1) Exception - базовый тип исключений

//2) FormatException - возникает при неправильном формате ввода

//3) NullReferenceException - в экземпляре не задана ссылка на объект

//4) IndexOutOfRangeException - индекс вне границ массива

//5) FileNotFoundException - Файл не найден

//6) DivideByZeroException - деление на 0

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Калькулятор";

            double a, b;
            char c;

            L1:

            try
            {
                Console.WriteLine("Ведите a:");
                a = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите арифметическое действие:");
                c = char.Parse(Console.ReadLine());

                Console.WriteLine("Ведите b:");
                b = double.Parse(Console.ReadLine());

                switch (c)
                {
                    case '+':

                        Console.WriteLine("Сумма: " + (a + b));

                        goto L1;

                    case '-':

                        Console.WriteLine("Разность: " + (a - b));
                        
                        goto L1;

                    case '*':

                        Console.WriteLine("Произведение: " + (a * b));

                        goto L1;

                    case '/':

                        Console.WriteLine("Частное: " + (a / b));

                        goto L1;

                    default:

                        Console.WriteLine("Ошибка! (Неверный знак!)");

                        goto L1;                   
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка!");

                goto L1;
            }
            finally
            {
                Console.WriteLine("_________________");

            }
        }
    }
}
