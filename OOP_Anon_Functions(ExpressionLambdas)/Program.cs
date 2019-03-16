using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Anon_Functions_ExpressionLambdas_ //Выражения лямбды
{
    class Program
    {

        public delegate void HelloDelegate();

        static void Main(string[] args)
        {
            HelloDelegate hD = () => Console.WriteLine("Hello!");

            hD();

            Console.ReadKey();
        }
    }
}
