using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Anon_Functions_ExpressionLambdas3_
{

    public delegate string StrDelegate(string s, int x);

    class Program
    {
        static void Main(string[] args)
        {
            StrDelegate sD = (string str, int a) => str + Convert.ToString(a);

            Console.WriteLine(sD("abc", 123));

            Console.ReadKey();
        }
    }
}
