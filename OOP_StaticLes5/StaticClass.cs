using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_StaticLes5
{
    static class StaticClass
    {
        static StaticClass()
        {
            field = 10;

            dField = 3.5;
        }

        public static int field;

        public static double dField;

        public static void GetSum()
        {
            Console.WriteLine(field + dField);
        }
    }
}
