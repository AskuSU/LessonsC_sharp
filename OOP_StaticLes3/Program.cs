using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_StaticLes3
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass myClass = AbstractClass.Create();

            myClass.Method();

            Console.ReadKey();
        }
    }
}
