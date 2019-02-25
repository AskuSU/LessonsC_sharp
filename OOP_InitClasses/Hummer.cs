using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_InitClasses
{
    class Hummer
    {
        public string firm = null;

        public string Material { get; set; }

        public int Weight { get; set; }

        public int price;

        public Hummer()
        {

        }

        public Hummer(int price)
        {
            this.price = price;

        }
    }
}
