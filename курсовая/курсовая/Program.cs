using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace курсовая
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
            StreamReader reader = new StreamReader("..\\..\\test" + n + ".txt", Encoding.GetEncoding("Windows-1251")); //читает файл
            if (reader.EndOfStream)
            {
                Console.Write("Файл пуст");
                return;
            }

            FileInfo file = new FileInfo("..\\..\\test" + n + ".txt");//Проверка размера файла
            long Mb = file.Length / 1024 / 1024 ;
            if (Mb >= 2048)
            {
                Console.WriteLine("ОШИБКА! Исходный файл более 2Гб ");
                return;
            }

            int L = 0, LL = 0, j = 0;
            string a;

            String filename = "OTVET.html";//
            StreamWriter writer = new StreamWriter(filename, false, Encoding.Unicode);// создание файла для вывода

            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine(); //читает первую строку
                String[] arr = line.Split(' '); //создаёт массив с разделителем "пробел"
                L = arr.Length;// длина массива
                j = 0;
                while (j < L)
                {
                    a = arr[j];//одно слово
                    a = a.ToLower();//перевод в нижний регистр
                    a = a.Replace(".", "");
                    a = a.Replace(",", "");
                    a = a.Replace("!", "");
                    a = a.Replace("?", "");
                    a = a.Replace("-", "");
                    string input = a;
                    char[] inputarray = input.ToCharArray();
                    Array.Reverse(inputarray);// реверс значений
                    string output = new string(inputarray);
                    LL = output.Length;
                    if (output == a && LL > 2)
                    {
                        Console.WriteLine(a);
                        writer.WriteLine(a);//вывод в файл
                    }

                    j++;
                }

            }
            writer.Close();//вывод в файл конец
        }
    }
}
