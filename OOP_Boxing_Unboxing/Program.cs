using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            //boxing
            object obj = i;

            //unboxing
            int j = (int)obj;

            Console.WriteLine(j);

            Console.ReadKey();

        }
    }
}
