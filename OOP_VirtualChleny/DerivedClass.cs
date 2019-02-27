using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_VirtualChleny
{
    class DerivedClass : BaseClass
    {
        public override void Method()
        {
            Console.WriteLine("Метод из класса DerivedClass");
        }
    }
}
