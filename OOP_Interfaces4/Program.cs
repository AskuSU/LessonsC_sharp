using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interfaces4
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dClass = new DerivedClass();

            IInterfaceA dClassUpToA = dClass;

            dClassUpToA.Method();

            IInterfaceB dClassUpToB = dClass as IInterfaceB;

            dClassUpToB.Method();

            Console.ReadKey();
        }
    }
}
