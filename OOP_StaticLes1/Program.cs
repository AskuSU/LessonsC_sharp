using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_StaticLes1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mC1 = new MyClass();

            mC1.age = 17;
            mC1.height = 180;

            mC1.GetInfo();

            MyClass.filed = 67;

            MyClass.StaticMethod();

            MyClass.filed = 7;

            Console.WriteLine(MyClass.filed);

            Console.ReadKey();
        }
    }
}
