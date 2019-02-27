using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PrivedenieTipov3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание нового экземпляра класса DerivedClass

            DerivedClass dClass = new DerivedClass();

            dClass.jacket = "Футболка";

            dClass.longHair = "Коса";

            //UpCast

            BaseClass dClassUp = (BaseClass)dClass;

            dClassUp.jacket = "Майка";

            //DownCast

            DerivedClass dClassDown = (DerivedClass)dClassUp;

            dClassDown.jacket = "asdfd";

            dClassDown.longHair = "asd";

            Console.WriteLine("{0}, {1}, {2}", dClass.GetHashCode(), dClassUp.GetHashCode(), dClassDown.GetHashCode());

            Console.ReadKey();
        }
    }
}
