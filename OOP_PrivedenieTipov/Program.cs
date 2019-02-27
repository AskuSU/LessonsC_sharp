using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PrivedenieTipov
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dClass = new DerivedClass();

            Console.WriteLine(dClass.jacket + " " + dClass.longHair);

            Console.WriteLine(new string('-', 30));

            BaseClass dClassUp = (BaseClass)dClass;

            Console.WriteLine(dClassUp.jacket);

            Console.WriteLine(new string('-', 30));

            BaseClass dClassUp1 = dClass;

            Console.WriteLine(dClassUp1.jacket);

            Console.WriteLine(new string('-', 30));

            BaseClass dClassUp2 = new DerivedClass();

            Console.WriteLine(dClassUp2.jacket);

            Console.ReadKey();
        }
    }
}
