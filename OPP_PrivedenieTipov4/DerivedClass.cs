using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PrivedenieTipov4
{
    class DerivedClass : BaseClass
    {
        new public void Method()
        {
            Console.WriteLine("Метод из производного класса DerivedClass");
        }
    }
}
