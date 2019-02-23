using System;


namespace class_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Класс Console";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;

            double a, b;

            l1:

            Console.WriteLine("Введите а");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите b");
            b = double.Parse(Console.ReadLine());

            Console.Clear();

           

            Console.Beep();

            Console.WriteLine(a * b);

            Console.WriteLine("Для продолжения нажмите Enter, для выхода любую клавищу....");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                goto l1;       
            }
            else
            {
                Console.ReadKey();
            }
            
        }
    }
}
