using System;


namespace Math_op
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("Введите а");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите b");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Ар. действия: ");

            Console.WriteLine("Сумма: " + (a + b));
            Console.WriteLine("Разнось: " + (a - b));
            Console.WriteLine("Произведение: " + (a * b));
            Console.WriteLine("Частное: " + (a / b));

            Console.ReadKey();
        }
    }
}
