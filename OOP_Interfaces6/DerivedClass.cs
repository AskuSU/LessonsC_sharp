using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interfaces6
{
    class DerivedClass : IInterfaceA, IInterfaceB
    {
        public void Method()
        {
            Console.WriteLine("Метод интерфейса A и B");
        }
    }
}
