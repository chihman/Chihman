using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задание_9_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Vvedite nomer testa ");
            int n = int.Parse(Console.ReadLine());

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
            Console.WriteLine("Vvedite A: ");//
            String A = Console.ReadLine();
            Console.WriteLine("Vvedite B: ");//
            String B = Console.ReadLine();


            int J = 0;
            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine(); //читает первую строку
                int L = line.Length;

                int x1 = line.IndexOf(A);
                int x2 = line.IndexOf(B);
                if (x1 == -1 || x2 == -1)
                {
                    Console.Write("Bukva ne naidena ");
                    return;
                }
                if (x1==x2)
                {
                    Console.Write("Neskolko iskomyh bukv ");
                    return;
                }
               
                if (x1 > 1)
                {
                    Console.Write("Neskolko iskomyh znachenij  ");
                    return;
                }
                if (x1 > x2)
                {
                    int I = x1 - x2;
                    Console.Write(I-1);
                    return;
                }
                else
                {
                    int I = x2 - x1;
                    Console.Write(I-1);
                    return;
                }

               
               

            }

            Console.WriteLine(J - 1);
        }
    }
}
