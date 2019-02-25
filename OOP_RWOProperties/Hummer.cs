using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RWOProperties
{
    class Hummer
    {
        string mark = "Бригадир";

        int weigh = 0;

        public string Mark
        {
            get
            {
                return mark;
            }
        }

        public int Weigh
        {
            set
            {
                if (value != 0)
                {
                    weigh = value;
                }
            }
        }
    }
}
