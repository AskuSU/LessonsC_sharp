using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BaseMethod2
{
    class DerivedClass : BaseClass
    {
        public override void VMethod(int a, int b)
        {
            Console.WriteLine("Метеод сум. из класса DerivedClass");

            Console.WriteLine(a + b);

            base.VMethod(a, b);
        }
    }
}
