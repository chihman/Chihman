using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задание_9_8
{
    class Program
    {
        static void Main(string[] args)
        {

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
            int i = 0;
            string A = " ";
            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine(); //читает первую строку
                int L = line.Length;

                //char[] invalidPathChars = Path.GetInvalidPathChars(); //некорректное имя
               
           
                int LL = line.Length;
                a = 0;
                i = 0;
                while (a < LL)
                {
                    A = Convert.ToString(line[a]);
                    if (A == "*" || A == "|"  ||  A == "\"" || A == "<" || A == ">" || A == "?" || A == "/")
                    {
                        i++;
                       
                    }

                    a++;
                }

                if (i > 0)
                {
                    Console.Write("Некорректное имя файла ");
                  

                }
                else
                {

                    String result = Path.GetFileNameWithoutExtension(line); //выделяет имя
                    Console.Write(result + " ");
                }
            }

        }
    }
}

