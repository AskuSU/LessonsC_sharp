using System;


namespace OOP_Anon_Functions_Methods_
{

    public delegate void MyDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate mD = new MyDelegate(delegate { Console.WriteLine("Hello world!"); });

            mD(); //mD.Invoke();

            Console.ReadKey();
        }
    }
}
