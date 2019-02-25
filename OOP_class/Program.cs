using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{

    //class Hummer
    //{
    //    public string material;
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Hummer hummer = new Hummer(); // Доступ по сильной ссылке

            hummer.material = "Дерево";

            Console.WriteLine(hummer.material);

            //new Hummer().material = "Дерево"; // Доступ по слабой ссылке 
            //Console.WriteLine(new Hummer().material);

            Console.ReadKey();
        }
    }
}
