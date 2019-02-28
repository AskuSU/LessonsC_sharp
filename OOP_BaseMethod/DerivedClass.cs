using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BaseMethod
{
    class DerivedClass : BaseClass
    {
        public override void VMethod()
        {
            Console.WriteLine("Переопределенный метод из производного класса DerivedClass ");

            base.VMethod();
        }
    }
}
