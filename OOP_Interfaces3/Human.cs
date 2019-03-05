using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interfaces3
{
    class Human : IThinking, ISpeaking
    {
        
        public void SpeakLoud(string s)
        {
            Console.WriteLine("Говорит громко - {0}", s);
        }

        public void SpeakNormal(string s)
        {
            Console.WriteLine("Говорит нормально - {0}", s);
        }

        public void ThinkAboutSmth(string s)
        {
            Console.WriteLine("Думает - {0}", s);
        }
    }
}
