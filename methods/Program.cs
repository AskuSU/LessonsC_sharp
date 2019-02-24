using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        //Процедура
        public void Add(int int_a, int int_b)
        {
            Console.WriteLine(int_a + int_b);
        }

        static public void Add1( int int_a, int int_b)
        {
            Console.WriteLine(int_a + int_b);
        }

        //Функция

        public int Add2(int int_a, int int_b)
        {
            return int_a + int_b;
        }

        static public int Add3(int int_a, int int_b)
        {
            return int_a + int_b;
        }


        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Введиете a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введиете b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("public void Add");
            Program p = new Program();
            p.Add(a, b);

            Console.WriteLine("static public void Add1");
            Program.Add1(a, b);

            Console.WriteLine("public int Add2 " + p.Add2(a, b));


            Console.WriteLine("static public int Add3 " + Add3(a, b));

            Console.ReadKey();
        }
    }
}
