using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PartialMethod
{
    partial class Hummer
    {
        partial void Method1()
        {
            Console.WriteLine("Method1()");
        }

        partial void Method2()
        {
            Console.WriteLine("Method2()");
        }

        public void StartMethods()
        {
            Method1();
            Method2();
        }

    }
}
