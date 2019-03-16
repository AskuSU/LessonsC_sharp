using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GenericTypes
{
    class SomeClass<T> // Т- УМЗТ - Указатель Места Заполнения Типом
    {
        public SomeClass()
        {

        }

        public SomeClass(T arg)
        {
            SomeField = arg;
        }

        private T someFiled;

        public T SomeField
        {
            get
            {
                return someFiled;
            }
            set
            {
                someFiled = value;
            }
        }

        public T Filed { get; set; }

        public void Method()
        {
            Console.WriteLine(Filed.GetType());
        }

        

    }
}
