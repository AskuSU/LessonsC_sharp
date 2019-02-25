using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_InitClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Hummer hummer = new Hummer(2000)
            {
                firm = "Бригадир",

                Material = "Дерево",

                Weight = 2
            };

            Console.WriteLine("Фирма {0}, материал {1}, вес {2}, цена {3}", hummer.firm, hummer.Material, hummer.Weight, hummer.price);

            Console.ReadKey();
        }
    }
}
