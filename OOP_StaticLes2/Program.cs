using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_StaticLes2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(MyClass.filed);

            //MyClass mC = new MyClass();

            MyClass.filed = 6;

            Console.ReadKey();
        }
    }
}
