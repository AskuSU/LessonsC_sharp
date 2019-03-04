using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dClass = new DerivedClass();

            dClass.Method();

            dClass.Method1();

            dClass.Method2();

            dClass.Method3();

            Console.ReadKey();
        }
    }
}
