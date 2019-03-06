using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_StaticLes1
{
    class MyClass
    {
        public int age;

        public int height;

        public static int filed;

        public static void StaticMethod()
        {
            Console.WriteLine(filed);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Возраст: {age}\nРост: {height}");
        }
    }
}
