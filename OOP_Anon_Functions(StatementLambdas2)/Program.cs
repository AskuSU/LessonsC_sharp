using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Anon_Functions_StatementLambdas2_
{

    public delegate int SubDelegate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            //SubDelegate sD = (s, d) =>
            //{
            //    int res = s - d;

            //    return res;
            //};

            // int c = sD(10, 8);

            int c = new SubDelegate((s, d) =>
            {
                return s - d;
            }).Invoke(10, 8);

            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
