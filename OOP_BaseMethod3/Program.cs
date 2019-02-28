using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BaseMethod3
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dClass = new DerivedClass();

            dClass.Method(1, 4);

            Console.ReadKey();
        }
    }
}
