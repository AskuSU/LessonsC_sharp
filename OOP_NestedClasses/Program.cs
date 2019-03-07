using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NestedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            MainClass.NestedClass nC = new MainClass.NestedClass();

            nC.Method();

            MainClass.DerivedNested dN = new MainClass.DerivedNested("Hello");

            Console.WriteLine(dN.GetField());

            dN.BaseMethod();

            dN.Shout("I LOVE C#");

            Console.ReadKey();
        }
    }
}
