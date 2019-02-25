using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ConstuctorClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Hummer hummer = new Hummer(2000);

            Console.WriteLine("Фирма {0}, материал {1}, цена {2}, вес {3}", hummer.Firm, hummer.material, hummer.price, hummer.weight);

            Console.ReadKey();
        }
    }
}
