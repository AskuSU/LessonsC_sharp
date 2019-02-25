using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imenova_parametry
{
    class Program
    {
        static int Add(int a, int b, int c = 0, int d = 0) //Не обязательные параметры
        {
            return (a + b + c + d);
        }

        static void Person(string name, int date, string gender)
        {
            Console.WriteLine("Имя {0}, \nДата рождения {1}, \nПол {2}", name, date, gender);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Add(1, 2));

            //Console.WriteLine(Add(1, 2, 10, 7));

            string newName = Console.ReadLine();

            int newDate = int.Parse(Console.ReadLine());

            string newGender = Console.ReadLine();

            //Person(newName, newDate, newGender);

            Person(date: newDate, gender: newGender, name: newName);

            Console.ReadKey();
        }
    }
}
