using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods2
{
    class Program
    {
        public static bool Chet(int a)
        {
            bool b = true;

            if ((a % 2) != 0)
            {
                b = false;
            }

            return b;
        }

        public static int SumCifr(int a)
        {
            int s = 0;

            while (a != 0)
            {
                s += a % 10;
                a /= 10;
            }

            return s;
        }

        static void Main(string[] args)
        {
            int a;

            a = int.Parse(Console.ReadLine());

            if (Chet(a))
            {
                Console.WriteLine(SumCifr(a));

            }
            else
            {
                Console.WriteLine("Нечетное");
            }

            Console.ReadKey();

        }
    }
}
