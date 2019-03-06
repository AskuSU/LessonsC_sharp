using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Compares
{

    class HeightComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.height < y.height)
                return -1;
            else if (x.height > y.height)
                return 1;
            else
                return 0;
        }
    }
}
