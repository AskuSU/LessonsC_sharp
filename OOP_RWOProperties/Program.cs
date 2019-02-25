using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RWOProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Hummer hummer = new Hummer();

            string weigh = Console.ReadLine();

            Console.WriteLine(hummer.Mark);

            Console.ReadKey();
        }
    }
}
