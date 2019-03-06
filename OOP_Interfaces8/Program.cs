using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interfaces8
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dClass = new DerivedClass();

            Console.WriteLine(dClass.SayHello("Алексей"));

            Console.ReadKey();
        }
    }
}
