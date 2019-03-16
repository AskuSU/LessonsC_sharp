using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DelegatesArray2
{

    public delegate void MyDelegate(string s);

    class Program
    {

        private static void SayHello(string str)
        {
            Console.WriteLine("Hello, " + str);
        }

        private static void SayGoodbye(string str)
        {
            Console.WriteLine("Goodbye, " + str);
        }

        private static void AskHowAreYou(string str)
        {
            Console.WriteLine("How Are You, " + str);
        }

        static void Main(string[] args)
        {
            MyDelegate[] methodsArray = new MyDelegate[]
            {
                //SayHello, SayGoodbye, AskHowAreYou
                delegate (string s)
                {
                    Console.WriteLine("Hello, " + s);
                },

                (s) =>
                {
                    Console.WriteLine("Goodbye, " + s);
                },

                (s) => Console.WriteLine("How Are You, " + s)
        };

            for (int i = 0 ; i < methodsArray.Length; i++)
            {
                methodsArray[i](Convert.ToString(i));
            }

            Console.ReadKey();
        }
    }
}
