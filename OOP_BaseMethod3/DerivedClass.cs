using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BaseMethod3
{
    class DerivedClass : BaseClass
    {
        new public void Method(int a, int b)
        {
            Console.WriteLine("Переопределенный метод из производного класса DerivedClass ");

            Console.WriteLine(a + b);

            base.Method(a, b);
        }
    }
}
