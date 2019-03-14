using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Enums
{
    enum Number
    {
        Zero,
        One,
        Two,
        Three
    }

    class Program
    {
        private static Number myDigit = Number.One;

        static void Main(string[] args)
        {
            Number digit = Number.Two;

            Console.WriteLine(digit);

            Console.WriteLine((int)digit);

            Console.WriteLine(new string('-', 30));

            Console.WriteLine(Number.Three);

            Console.WriteLine((int)Number.Three);

            Console.WriteLine(new string('-', 30));

            Console.WriteLine((int)myDigit);

            Console.ReadKey();
        }
    }
}
