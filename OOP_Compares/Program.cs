using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Compares
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] mas = new Person[10];

            Random r = new Random();

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = new Person(r.Next(1, 95), r.Next(30, 190), r.Next(20, 95));

                Console.WriteLine(mas[i].age + " " + mas[i].height + " " + mas[i].weight);

            }

            //Array.Sort(mas);

            Array.Sort(mas, new HeightComparer());

            Console.WriteLine(new string('-', 30));

            for (int i = 0; i < mas.Length; i++)
            {
              
                Console.WriteLine(mas[i].age + " " + mas[i].height + " " + mas[i].weight);

            }

            Console.ReadKey();
        }
    }
}
