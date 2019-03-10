using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ArrayListLes
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList List = new ArrayList();

            List.Add(23);

            List.Add("Hello");

            List.Add("!");

            foreach (object o in List)
            {
                Console.Write(o + "  ");
            }

            Console.WriteLine("\n" + List.Count);

            Console.WriteLine(new string('-',30));

            List.AddRange(new double[] {2.4, 1.98, 6.45});

            for (int i = 0; i < List.Count; i++)
            {
                Console.Write(List[i] + "  ");
            }

            Console.WriteLine("\n" + new string('-', 30));

            List.Insert(2, "world");

            for (int i = 0; i < List.Count; i++)
            {
                Console.Write(List[i] + "  ");
            }

            Console.WriteLine("\n" + new string('-', 30));

            ArrayList sList = new ArrayList
            {
                'l', 'o', 'v', 'e', ' ', 'c', '#'
            };

            List.InsertRange(List.Count - 1, sList);

            for (int i = 0; i < List.Count; i++)
            {
                Console.Write(List[i] + "  ");
            }

            Console.WriteLine("\n" + new string('-', 30));

            List.Add("Hello");

            Console.WriteLine(List.IndexOf("Hello") + " Место");

            Console.WriteLine(List.LastIndexOf("Hello") + " Место");

            for (int i = 0; i < List.Count; i++)
            {
                Console.Write(List[i] + "  ");
            }

            Console.WriteLine("\n" + new string('-', 30));

            List.Remove("Hello");

            for (int i = 0; i < List.Count; i++)
            {
                Console.Write(List[i] + "  ");
            }

            Console.WriteLine("\n" + new string('-', 30));

            List.RemoveAt(List.IndexOf("Hello"));

            for (int i = 0; i < List.Count; i++)
            {
                Console.Write(List[i] + "  ");
            }

            Console.WriteLine("\n" + new string('-', 30));

            List.RemoveRange(3, 2);

            for (int i = 0; i < List.Count; i++)
            {
                Console.Write(List[i] + "  ");
            }

            Console.WriteLine("\n" + new string('-', 30));

            List.Add(90);

            List.Insert(3, 90);

            List.Insert(6, 90);

            for (int i = 0; i < List.Count; i++)
            {
                Console.Write(List[i] + "  ");
            }

            Console.WriteLine();

            while (List.Contains(90))
            {
                List.Remove(90);
            }

            for (int i = 0; i < List.Count; i++)
            {
                Console.Write(List[i] + "  ");
            }

            Console.WriteLine("\n" + new string('-', 30));

            IEnumerator en = List.GetEnumerator();

            while (en.MoveNext())
            {
                Console.Write(en.Current + ", ");
            }

            Console.WriteLine("\n" + new string('-', 30));

            Console.ReadKey();
        }
    }
}
