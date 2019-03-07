using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ExMethods
{
    static class ExtensionClass
    {
        public static void SayLOL(this string s)
        {
            Console.WriteLine($"{s}, LOL)))))");
        }

        public static string AddStrings(this string s, params string[] strings)
        {
            for (int i=0; i < strings.Length; i++)
            {
                s += $" {strings[i]}";
            }

            return s;
        }
    }
}
