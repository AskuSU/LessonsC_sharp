using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GenericTypes2
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass someClass = new SomeClass();

            someClass.SomeMethod<string>("Hello!");

            someClass.SomeMethod("world");

            Console.ReadKey();
        }
    }
}
