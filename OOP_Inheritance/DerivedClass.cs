using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    class DerivedClass : BaseClass
    {
        //public DerivedClass()
        //{
        //    pubField = "DerivedClass.pubField";

        //    protField = "DerivedClass.protField";

        //}
        public DerivedClass()
        {
                
        }

        public DerivedClass(string s)
        {
            pubField = s;
        }

        new public void Method()
        {
            Console.WriteLine("Метод DerivedClass");
        }

    }
}
