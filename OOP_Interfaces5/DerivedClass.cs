using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interfaces5
{
    class DerivedClass : IInterfaceB
    {
        void IInterfaceB.Method()
        {
            Console.WriteLine("Метод интерфейса А");
        }

        void IInterfaceA.Method()
        {
            Console.WriteLine("Метод интерфейса B");
        }
    }
}
