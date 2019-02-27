using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BaseConstr
{
    class DerrivedClass : BaseClass
    {
        public DerrivedClass() : base()
        {
            Console.WriteLine("Конструктор DerrivedClass без параметров\n{0}, {1}", Firm, Material);

            Console.WriteLine(new string('-', 30));
        }

        public DerrivedClass(string firm, string material) : base(firm, material)
        {
            Console.WriteLine("Конструктор DerrivedClass с параметрами типа стринг вызывающий конструктор BaseClass с параметрами типа стринг\n {0}, {1}", Firm, Material);

            Console.WriteLine(new string('-', 30));
        }
    }
}
