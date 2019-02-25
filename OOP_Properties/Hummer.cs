using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Properties
{
    class Hummer
    {
        string material = null;

        public string Material
        {
            get
            {
                return material;
            }
            set
            {
                if (value.ToLower() != "пластилин")
                {
                    material = value;
                }
            }
        }
    }
}
