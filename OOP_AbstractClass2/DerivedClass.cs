using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AbstractClasses2
{
    class DerivedClass : CClass
    {
        public override void Method()
        {
            Console.WriteLine("Method");
        }

        public override int Addition(int a, int b)
        {
            return a + b;
        }

        public override string SayHello(string s)
        {
            return $"Привет {s}!";
        }

        public string SayHello(string s, string s1)
        {
            return $"Привет {s}, {s1}!";
           // Console.WriteLine($"Привет {s}, {s1}!");
        }
    }
}
