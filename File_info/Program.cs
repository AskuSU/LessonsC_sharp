using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_info
{
    class Program
    {
        static void Main(string[] args)
        {
            string path, path_copy;

            Console.WriteLine("Введите путь к файлу + имя");
            path = Console.ReadLine();

            //Console.WriteLine("Введите новый путь к файлу");
            //path_copy = Console.ReadLine();

            //FileInfo

            FileInfo file = new FileInfo(path);

            //if (file.Exists)
            //{
            //    Console.WriteLine("Файл существует");
            //    file.CopyTo(path_copy);
            //}
            //else
            //{
            //    Console.WriteLine("Файл не существует");
            //}

            //file.Delete();
            //file.Create();
            //file.MoveTo(path_copy);   //Перенос файла


            //File

            //File.Create(path);
            //File.Copy(path, path_copy, false);
            //File.Delete(path);
            //File.Move(path, path_copy);

            Console.WriteLine("Имя файла: "+ file.Name );

            Console.WriteLine("Полное имя файла: " + file.FullName);
            Console.WriteLine("Путь: " + file.Directory);
            Console.WriteLine("Размер:"+ file.Length);
            Console.WriteLine("Расширение: "+ file.Extension);
            Console.WriteLine("Время создания: " + file.CreationTime);

            Console.WriteLine("Программа завершена...");

            Console.ReadKey();
        
        }
    }
}
