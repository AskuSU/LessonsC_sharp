using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Hummer hummer = new Hummer();

            string mat = Console.ReadLine();

            hummer.Material = mat;

            Console.WriteLine(hummer.Material);

            Console.ReadKey();
        }
    }
}
