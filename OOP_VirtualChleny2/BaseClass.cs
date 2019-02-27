using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_VirtualChleny2
{
    class BaseClass
    {
        public virtual void VMethod()
        {
            Console.WriteLine("Виртуальный метод из класса BaseClass");
        }

        public void Method()
        {
            Console.WriteLine("Обычный метод из класса BaseClass");
        }

    }
}
