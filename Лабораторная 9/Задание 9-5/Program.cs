using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задание_9_5
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
            int a = 0;
            int J = 0;
            int x = 0;
            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine(); //читает первую строку
                int L = line.Length;
                i = 0;
                x = 0;
                a = 0;
                while (i + 1 < L)
                {
                    
                    x = 0;
                    if (line[i] == line[i + 1])
                    {
                        x++;
                        if (x == 1&&a<1)
                        {
                            J=J+1;
                            x = 0;
                            a++;
                        }
                    }
                    i++;
                    
                }
            }

            Console.WriteLine(J);




        }


    }
}
