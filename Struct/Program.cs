using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {

        struct Student
        {
            public string name;

            public int date;
        }

        static void Main(string[] args)
        {
            Student st = new Student();

            Console.WriteLine("Введите имя ученика");

            st.name = Console.ReadLine();

            Console.WriteLine("Введите дату рождения");

            st.date = int.Parse(Console.ReadLine());

            Console.WriteLine("Имя {0}\nДата рождения {1}", st.name, st.date);

            Console.ReadKey();
           
        }
    }
}
