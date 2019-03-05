using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interfaces3
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();

            human.SpeakLoud("Я люблю программирование!");

            human.ThinkAboutSmth("О C# больше всего)))");

            Console.ReadKey();
        }
    }
}
