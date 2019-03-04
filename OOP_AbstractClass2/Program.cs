using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AbstractClasses2
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dClass = new DerivedClass();



            //dClass.Method();

            //int c = dClass.Addition(2, 5);

            //Console.WriteLine(c);

            //Console.WriteLine(dClass.SayHello("Вася"));


            AClass dClassUpToAClass = (AClass)dClass;

            dClassUpToAClass.Method();

            BClass dClassUpToBClass = dClass as BClass;

            dClassUpToBClass.Method();

            int i = dClassUpToBClass.Addition(2, 4);

            Console.WriteLine(i);

            CClass dClassUpToCClass = (CClass)dClass;

            Console.WriteLine(dClassUpToCClass.SayHello("Петр"));

            Console.WriteLine(dClass.SayHello("Петр", "Иван"));

            Console.ReadKey();
        }
    }
}
