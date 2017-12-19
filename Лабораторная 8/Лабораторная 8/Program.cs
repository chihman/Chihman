using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_8
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int a = 0;
            Console.Write(" Введите a ");
            a = Convert.ToInt32( Console.ReadLine());
            Console.Write(" Введите данные ");
            String data = Console.ReadLine();


        
            if (String.IsNullOrWhiteSpace(data))
            { Console.Write("Строка пуста");
                return;
            }
            String[] arr = data.Split(' '); 


            if (a < 0 || arr.Length <= a) 
            {
                Console.Write("Число а должно быть в интервале (0, размер массива)");
                return;
                   }
            Console.Write(arr[a]);
        }
    }
}
