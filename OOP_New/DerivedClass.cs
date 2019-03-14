using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_New
{
    class DerivedClass : BaseClass
    {
        new public int Age { get; }

        new public void Say(string s)
        {
            Console.WriteLine(s.ToUpper());
        }
    }
}
