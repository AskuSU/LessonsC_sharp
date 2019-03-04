using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AbstractClasses
{
    class DerivedClass : AClass
    {
        public override void Method()
        {
            Console.WriteLine("Method класса AClass реализованный в производном классе DerivedClass");
        }

        public override void Method3()
        {
            Console.WriteLine("Method3 класса AClass реализованный в производном классе DerivedClass");
        }
    }
}
