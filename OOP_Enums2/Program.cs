using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Enums2
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
        static void Main(string[] args)
        {
            for (Number n = Number.Zero; n <= Number.Three; n++)
            {
                Console.Write($"{n}  :  {(int)n}\n");
            }

            Console.ReadKey();
        }
    }
}
