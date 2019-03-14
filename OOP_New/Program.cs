using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_New
{
    class Program
    {
        static void Main(string[] args)
        {
            //new - оператор

            MyClass mC = new MyClass();

            mC.SayHello();

            //new - модификатор

            DerivedClass dC = new DerivedClass();

            dC.Say("Hello!");

            

            //new - ограничитель

            GenericClass<MyClass> gC = new GenericClass<MyClass>();

            gC.GetNewT().SayHello();

            Console.ReadKey();
        }
    }
}
