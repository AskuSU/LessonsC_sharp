using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ConstuctorClass
{
    class Hummer
    {
        string firm = null;

        public string Firm
        {
            get
            {
                return firm;
            }
            set
            {
                firm = value;
            }
        }

        public string material = null;

        public int price;

        public int weight;

        #region Конструкторы

        public Hummer()
        {

        }

        public Hummer(string firm)
        {
            Firm = firm;
        }

        public Hummer(string firm, string material, int weight)
        {
            Firm = firm;

            this.material = material;

            this.weight = weight;
        }

        public Hummer(int price) : this("Бригадир", "Дерево", 2)
        {
            this.price = price;
   
        }

        #endregion

    }
}
