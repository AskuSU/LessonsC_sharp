using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polya
{
    class Program
    {

        public int a;

        static public int aa;

        private int b;

        int c;

        protected int d;

        //internal int e;
        
        //protected internal g;

        static void Main(string[] args)
        {
            Program p = new Program();

            p.a = int.Parse(Console.ReadLine());

            p.b = int.Parse(Console.ReadLine());

            p.c = int.Parse(Console.ReadLine());

            p.d = int.Parse(Console.ReadLine());

            Program.aa = 0;
        }
    }
}
