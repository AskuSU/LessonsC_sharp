using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BaseMethod2
{
    class BaseClass
    {
        public virtual void VMethod(int a, int b)
        {
            Console.WriteLine("Метод сум. из класса BaseClass");

            Console.WriteLine(a + b);
        }       
    }
}
