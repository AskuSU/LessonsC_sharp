using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NestedClasses
{
    class MainClass
    {
        public string Name { get; set; }

        public void MMethod()
        {
            Console.WriteLine("Метод из класса MainClass");
        }

        public class NestedClass
        {
            public void Method()
            {
                Console.WriteLine("Метод из NestedClass");
            }
        }

        public class DerivedNested : BaseClass, ISpeech
        {
            private string field;

            public DerivedNested(string s)
            {
                field = s;
            }

            public string GetField()
            {
                return field;
            }

            public void Say(string s)
            {
                Console.WriteLine(s);
            }

            public void Shout(string s)
            {
                Console.WriteLine(s + " said loudly");
            }
        }
    }
}
