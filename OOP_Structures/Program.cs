using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Structures
{
    struct Rectangle
    {
        static Rectangle()
        {
            Console.WriteLine("Hello");
        }

        public Rectangle(int a, int b)
        {
            this.a = a;

            this.b = b;
        }

        public int a;

        public int b;

        public static int GetS(Rectangle rect)
        {
            return rect.a * rect.b;
        }

        public int GetP()
        {
            return 2 * (a + b);
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(7, 8);

            //Rectangle rect;

            //rect.a = 10;

            //rect.b = 9;

            Rectangle rect1 = rect;

            Console.WriteLine(rect.a + " " + rect.b);

            Console.WriteLine(Rectangle.GetS(rect));

            Console.WriteLine(rect.GetP());

            Console.ReadKey();
        }
    }
}
