using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PrivedenieTipov4
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dClass = new DerivedClass();

            dClass.Method();

            BaseClass dClassUp = dClass;

            dClassUp.Method();

            DerivedClass dClassDown = (DerivedClass)dClassUp;

            dClassDown.Method();

            Console.ReadKey();
        }
    }
}
