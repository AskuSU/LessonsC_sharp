using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AccsessMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Hummer hummer = new Hummer();

            string mat = Console.ReadLine();

            if (hummer.SetField(mat))
            {
                Console.WriteLine(hummer.GetField());
            }
            else
            {
                Console.WriteLine(mat + " - недопустимое значение");
            }

            hummer.SetField2(mat);

            Console.ReadKey();
        }
    }
}
