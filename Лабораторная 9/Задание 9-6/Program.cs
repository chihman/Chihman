using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задание_9_6
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

            int J = 0;
            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine(); //читает первую строку
                int L = line.Length;

                int x = line.IndexOf(A);
                if (x == -1)
                {
                    Console.Write("Bukva ne naidena ");
                    return;
                }
                if (x>1)
                {
                    Console.Write("Neskolko iskomyh znachenij  ");
                    return;
                }
                J= L - x;
            }

            Console.WriteLine(J-1);
        }
    }
}
