using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AccsessMethods
{
    class Hummer
    {
        string material = null;

        public string GetField() //getter, геттер, аксессор
        {
            return material;
        }

        public bool SetField(string material) //setter, сеттер, мутатор
        {
            if (material.ToLower() != "пластилин")
            {
                this.material = material;

                return true;
            }
            else
            {
                return false;
            }        
            
        }

        public void SetField2(string material)
        {
            if (material.ToLower() == "пластилин")
            {
                Console.WriteLine(material + " - Недопустимое значение");
            }
            else
            {
                this.material = material;

                Console.WriteLine(material);
            }
        }
    }
}
