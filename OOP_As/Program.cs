using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_As
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dClass = new DerivedClass();

            dClass.Method();

            dClass.Method1();

            dClass.Method2();

            Console.WriteLine(dClass.GetHashCode());

            Console.WriteLine(new string('-', 30));

            BaseClass dClassUp = dClass as BaseClass;

            dClassUp.Method();
            
            Console.WriteLine(dClassUp.GetHashCode());

            Console.WriteLine(new string('-', 30));

            DerivedClass dClassDown = dClassUp as DerivedClass;

            dClassDown.Method();

            dClassDown.Method1();

            dClassDown.Method2();

            Console.WriteLine(dClassDown.GetHashCode());

            Console.ReadKey();
        }
    }
}
