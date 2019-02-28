using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_IsAs
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bClass = null;

            DerivedClass dClass = new DerivedClass();

            if (dClass is BaseClass)
            {
                bClass = dClass;

                Console.WriteLine("UpCast произведен");
            }
            else
            {
                bClass = null;
            }
            Console.ReadKey();
        }
    }
}
