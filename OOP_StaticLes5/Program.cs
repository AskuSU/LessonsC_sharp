using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_StaticLes5
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticClass.field = 30;

            StaticClass.dField = 1.5;

            StaticClass.GetSum();

            Console.ReadKey();
        }
    }
}
