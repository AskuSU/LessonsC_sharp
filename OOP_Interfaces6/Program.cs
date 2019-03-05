using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interfaces6
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dClass = new DerivedClass();

            dClass.Method();

            IInterfaceA dClassUpToA = dClass as IInterfaceA;

            dClassUpToA.Method();

            IInterfaceB dClassUpToB = dClass;

            dClassUpToB.Method();

            Console.ReadKey();
        }
    }
}
