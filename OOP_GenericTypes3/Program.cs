using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GenericDelegates
{
    class Program
    {

        public static int GetStrLength(string s)
        {
            return s.Length;
        }

        public static string MakeStrUpperCase(string s)
        {
            return s.ToUpper();
        }

        static void Main(string[] args)
        {
            MyDelegate<string, int> myDelegate = new MyDelegate<string, int>(GetStrLength);

            Console.WriteLine(myDelegate("Hello!"));

            MyDelegate<string, string> myDelegate2 = new MyDelegate<string, string>(MakeStrUpperCase);

            Console.WriteLine(myDelegate2.Invoke("asdfsdfFSDfdsdsf"));

            Console.ReadKey();
        }
    }
}
