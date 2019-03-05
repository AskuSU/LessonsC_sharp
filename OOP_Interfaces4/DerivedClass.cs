using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interfaces4
{
    class DerivedClass : IInterfaceA, IInterfaceB
    {
        void IInterfaceA.Method()
        {
            Console.WriteLine("Метод интерфейса А");
        }

        void IInterfaceB.Method()
        {
            Console.WriteLine("Метод интерфейса B");
        }
    }
}
