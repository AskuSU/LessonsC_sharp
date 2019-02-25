using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        static int Add(params int[] integers)
        {
            int s = 0;
            
            foreach (int i in integers)
            {
                s += i;
            }
            return s;
        }

        static int[] ChangeArray(params int[] integers)
        {
            for (int i = 0; i < integers.Length; i++)
            {
                integers[i] *= 2; 
            }
            return integers;
        }

        static void Main(string[] args)
        {
            int[] a = new int[] { 10, 2, 3, 4, 5 };

            Console.WriteLine(Add(a));
            Console.WriteLine();

            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            //a = ChangeArray(a);
            Console.WriteLine();
            foreach (int i in ChangeArray(a))
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.Write(a[0]);
            

            Console.ReadKey();

        }
    }
}
