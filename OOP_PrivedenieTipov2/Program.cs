using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PrivedenieTipov2
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dClass = new DerivedClass();

            Console.WriteLine(dClass.GetHashCode());

            BaseClass dClassUp = (BaseClass)dClass;

            Console.WriteLine(dClassUp.GetHashCode());

            BaseClass dClassUp1 = new DerivedClass();

            Console.WriteLine(dClassUp1.GetHashCode());

            Console.ReadKey();
        }
    }
}
