using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Boxing_Unboxing2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct mS = new MyStruct();

            //Тип 1 (в object)
            object boxed1 = mS;

            MyStruct unboxed1 = (MyStruct)boxed1;

            unboxed1.SayHello();

            //Тип 2 (в ValueType)
            ValueType boxed2 = mS;

            MyStruct unboxed2 = (MyStruct)boxed2;

            unboxed2.SayHello();

            //Тип 3 (в интерфейс)
            IInterface boxed3 = mS;

            MyStruct unboxed3 = (MyStruct)boxed3;

            unboxed3.SayHello();

            unboxed3.SayGoodbay();

            Console.ReadKey();

        }
    }
}
