using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BaseConstr
{
    class BaseClass
    {
        public string Firm { get; set; } = "Фирма не известна";

        public string Material { get; set; } = "Материал не известен";

        public BaseClass()
        {
            Console.WriteLine("Конструктор BaseClass без параметров");

            Console.WriteLine(new string('-', 30));
        }

        public BaseClass(string firm, string material)
        {
            Console.WriteLine("Конструктор BaseClass с параметрами типа стринг\n{0}, {1}", Firm, Material);

            Console.WriteLine(new string('-', 30));

            Firm = firm;

            Material = material;
        }
    }
}
