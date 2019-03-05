using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interfaces5
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dClass = new DerivedClass();

            IInterfaceA dClassUpToA = dClass as IInterfaceA;

            dClassUpToA.Method();

            Console.WriteLine(dClassUpToA.GetHashCode());

            IInterfaceB dClassUpToB = new DerivedClass();

            dClassUpToB.Method();

            Console.WriteLine(dClassUpToB.GetHashCode());

            Console.ReadKey();
        }
    }
}
