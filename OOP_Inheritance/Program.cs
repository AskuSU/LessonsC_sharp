using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dClass = new DerivedClass();

            //Console.WriteLine(dClass.pubField);

            //Console.WriteLine(new string('-', 20));

            //DerivedClass dClass2 = new DerivedClass("DerivedClass.pubField");

            //Console.WriteLine(dClass2.pubField);

            dClass.Method();

            Console.ReadKey();
        }
    }
}
