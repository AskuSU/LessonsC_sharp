using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_StaticLes2
{
    class MyClass
    {
        public static int filed = 3;

        static MyClass()
        {
            //filed = 1;
            Console.WriteLine("Статический конструктор");
        }

        public MyClass()
        {
            Console.WriteLine("Обычный конструктор");
        }
    }
}
