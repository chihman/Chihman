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
            StreamReader reader = new StreamReader("..\\..\\test" + n + ".txt"); //читает файл
            if (reader.EndOfStream)
            {
                Console.Write("Файл пуст");
                return;
            }
            int L = 0, LL = 0, i = 0, j = 0, I = 0;
            string a;
            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine(); //читает первую строку

                String[] arr = line.Split(' '); //создаёт массив с разделителем "пробел"
                L = arr.Length;// длина массива
                String x, y;
                int nomer = 0, revers = 0, S = 0;
                j = 0;
                while (j < L)
                {
                    a = arr[j];//одно слово
                    LL = a.Length;// длина slova
                    a = a.ToLower();//перевод в нижний регистр
                    revers = LL-1;// длина для вычитания
                    nomer = 0; // длина для прибавления
                    i++;
                    I = 0;
                    while (I < LL/2)
                    {
                        x = a.Substring(nomer, 1);
                        y = a.Substring(revers, 1);
                        nomer=nomer+1;
                        revers=revers-1;
                        if (x == y)
                        {
                            S++;
                        }
                        if (S == LL / 2 || S == LL / 2 + 1)
                        {
                            Console.WriteLine(a);
                        }
                        I++;

                    }
                    j++;
                }

            }
        }
    }
}
