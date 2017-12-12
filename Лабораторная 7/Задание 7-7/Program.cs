using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_7
{
    class Program
    {
        static void Main(string[] args)
        {
            String a,  c;
            int b;
            Console.Write("Введите данные ");
            a = Console.ReadLine();
            b = a.Length;
            if (b != 13) { Console.Write("Некорректная длина штрих-кода "); return; }
            Console.Write("Код страны: ");
           c = a.Substring(0, 2);
            Console.Write(c + "\n");
            Console.Write("Код изготовителя: ");
           c = a.Substring(3, 3);
            Console.Write(c + "\n");
            Console.Write("Код товара: ");
           c = a.Substring(7, 4);
            Console.Write(c + "\n");
            Console.Write("Контрольное число: ");
           c = a.Substring(12, 1);
            Console.Write(c + "\n");
        }
    }
}
