using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BaseConstr
{
    class Program
    {
        static void Main(string[] args)
        {
            DerrivedClass dClass = new DerrivedClass();

            DerrivedClass dClass1 = new DerrivedClass("Бригадир","Дерево");

            Console.ReadKey();
        }
    }
}
