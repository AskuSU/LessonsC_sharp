using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DelegatesArray
{

    public delegate void MyDelegate(string s);

    class Program
    {
        private static void SayHello(string str)
        {
            Console.WriteLine("Hello, " + str);
        }

        static void Main(string[] args)
        {
            //массив делегатов
            MyDelegate[] delsArray = new MyDelegate[10];

            for (int i = 0; i< delsArray.Length; i++)
            {
                //delsArray[i] = new MyDelegate(SayHello);
                delsArray[i] = SayHello;
            }

            for (int i = 0; i < delsArray.Length; i++)
            {
                delsArray[i](Convert.ToString(i));
            }

            Console.ReadKey();
        }
    }
}
