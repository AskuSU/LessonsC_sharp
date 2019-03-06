using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_StaticLes4
{
    class DerivedClass : BaseClass
    {
        new public static void Method()
        {
            Console.WriteLine("Метод из класса DerivedClass");
        }
    }
}
