using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Anon_Functions_Methods2_
{

    public delegate int AddDelegate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            AddDelegate aD = new AddDelegate(delegate (int number1, int number2)
            {
                int res = number1 + number2;

                return res;
            });

            int sum = aD(5, 4);

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
