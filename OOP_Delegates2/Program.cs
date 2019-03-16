using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Delegates2
{
    public delegate void MyDelegate();

    class Program
    {
        private static void Method1()
        {
            Console.WriteLine("Method1");
        }

        private static void Method2()
        {
            Console.WriteLine("Method2");
        }

        private static void Method3()
        {
            Console.WriteLine("Method3");
        }
        
        static void Main(string[] args)
        {
            MyDelegate mD = null;

            MyDelegate mD1 = new MyDelegate(Method1);

            MyDelegate mD2 = new MyDelegate(Method2);

            MyDelegate mD3 = new MyDelegate(Method3);

            //Комбинирование делегатов

            mD = mD1 + mD2 + mD3;

            //mD();

            l1:

            Console.WriteLine("Введите число от 1 до 7");

            int res = int.Parse(Console.ReadLine());

            switch (res)
            {
                case 1:
                    mD1();
                    break;
                case 2:
                    mD2.Invoke();
                    break;
                case 3:
                    mD3();
                    break;
                case 4:
                    mD();
                    break;
                case 5:

                    MyDelegate mD4 = mD - mD1;

                    mD4();

                    break;
                case 6:

                    MyDelegate mD5 = mD - mD2;

                    mD5();

                    break;
                case 7:

                    MyDelegate mD6 = mD - mD3;

                    mD6();

                    break;

                default:
                    goto l1;
                    
            }

            Console.ReadKey();
        }
    }
}
