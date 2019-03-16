using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GenericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass<int> sClass = new SomeClass<int>();

            sClass.Method();

            sClass.Filed = 1200;

            Console.WriteLine(sClass.Filed * 2);

            SomeClass<Phone> somePhone = new SomeClass<Phone>(new Phone() { Name = "LG G6", Price = 550 });

            Console.WriteLine(somePhone.SomeField.Name + " " + somePhone.SomeField.Price);


            Console.ReadKey();
        }
    }
}
