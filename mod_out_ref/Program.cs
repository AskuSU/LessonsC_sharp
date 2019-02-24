using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod_out_ref
{
    class Program
    {
        static void Add(double dbl_a, double dbl_b, out double dbl_s, out double dbl_r)
        {
            dbl_s = dbl_a + dbl_b;
            dbl_r = dbl_a - dbl_b;
           
        }

        static void Main(string[] args)
        {
            double a, b, s, r;

            Console.WriteLine("Введите a:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите b:");
            b = double.Parse(Console.ReadLine());

            Add(a, b, out s, out r);

            Console.WriteLine("Сумма: " + s);
            Console.WriteLine("Разность: " + r);

            Console.ReadKey();

            // out - передача значения
            // ref - передача по ссылке

        }
    }
}
