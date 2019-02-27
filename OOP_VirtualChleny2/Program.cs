using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_VirtualChleny2
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dClass = new DerivedClass();

            dClass.VMethod();

            dClass.Method();

            Console.WriteLine(new string('-',30));

            BaseClass dClassUp = dClass;

            dClassUp.VMethod();

            dClassUp.Method();

            Console.WriteLine(new string('-', 30));

            DerivedClass dClassDown = (DerivedClass)dClassUp;

            dClassDown.VMethod();

            dClassDown.Method();
            
            Console.ReadKey();
        }
    }
}
