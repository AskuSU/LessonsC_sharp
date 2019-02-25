using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Hummer hummer = new Hummer();

            hummer.Firm = "Бригадир";

            hummer.Material = "Дерево";

            Console.WriteLine("Фирма {0}, материал {1}", hummer.Firm, hummer.Material);

            Console.ReadKey();
        }
    }
}
