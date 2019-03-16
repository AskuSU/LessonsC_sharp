using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GenericTypes2
{
    class SomeClass
    {
        public void SomeMethod<P>(P arg)
        {
            P variable = arg;

            Console.WriteLine($"{variable}\n{variable.GetType()}");
        }
    }
}
