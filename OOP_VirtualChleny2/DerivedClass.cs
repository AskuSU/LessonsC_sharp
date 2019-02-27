using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_VirtualChleny2
{
    class DerivedClass : BaseClass
    {
        public override void VMethod()
        {
            Console.WriteLine("Перезаписаный метод из класса DerivedClass");
        }

        new public void Method()
        {
            Console.WriteLine("Обычный метод из класса DerivedClass");
        }

    }
}
