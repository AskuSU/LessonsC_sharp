using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ExMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string p = "Java";

            p.SayLOL();

            ExtensionClass.SayLOL("Python");

            string str = "we love";

            Console.WriteLine(str.AddStrings("C#","Java","C++"));

            string str1 = "I love".AddStrings("c#");

            Console.WriteLine(str1);

            Console.ReadKey();
        }
    }
}
