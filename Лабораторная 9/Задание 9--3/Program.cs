using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задание_9__3
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            int b = 0;
            int i = 0;
            Console.WriteLine("Vvedite nomer testa ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite simvol ");
            a = Console.ReadLine();
            if (!File.Exists("..\\..\\test" + n + ".txt")) //проверяет наличие файла
            {
                Console.Write("oshibka fail ne sushestvuet");
                return;
            }
            StreamReader reader = new StreamReader("..\\..\\test" + n + ".txt"); //читает файл
            if (reader.EndOfStream)
            {
                Console.Write("Файл пуст");
                return;
            }
            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine(); //читает первую строку

                b = line.IndexOf(a);
                if (b>-1)
                {
                    i++;
                }
                
            }
            Console.Write(i  + " ");


           
        }
    }
}
