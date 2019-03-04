using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AbstractClasses
{
    abstract class AClass
    {
        public abstract void Method();

        public abstract void Method3();


        public virtual void Method1()
        {
            Console.WriteLine("Method1 из AClass");
        }

        public void Method2()
        {
            Console.WriteLine("Method2 из AClass");
        }
    }
}
