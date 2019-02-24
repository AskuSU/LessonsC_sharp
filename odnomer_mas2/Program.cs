using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odnomer_mas2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];

            int[] b = new int[] { 123, 4234, 12323, 5, 12, 321, 42 };

            int[] c = new int[5] { 2, 3, 14, 34, 2 };

            string[] s = new string[] { "Зеленый", "Белый", "Красный" };

            char[] d = new char[5] { '6', '_', '+', '*', '|' };

            double[] e = new double[] { 2.8, 7.9 };

            for (int i = 0; i < b.Length; i++) 
            {
                Console.Write(b[i] + " ");
            }

            Console.Write("\n");

            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + ", ");
            }

            Console.Write("\n");

            for (int i = 0; i < d.Length; i++)
            {
                Console.Write(d[i] + ", ");
            }

            Console.Write("\n");

            for (int i = 0; i < e.Length; i++)
            {
                Console.Write(e[i] + " ");
            }

            Console.Write("\n");

            foreach (int i in b)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
