using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Boxing_Unboxing2
{
    struct MyStruct : IInterface
    {
        public void SayGoodbay()
        {
            Console.WriteLine("Goodbay!");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        
    }
}
