using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, L, n;
            i = 0;

            n = 0;
            String g,a;
            Console.Write(" Введите Х ");
            a = Convert.ToString(Console.ReadLine());
            string Q = "a,b,c,d,e,f,g,h";
            String[] arr = Q.Split(',');
            L = arr.Length;// dlinna massiva
           
            n = L;
            
            while (i < n)
            {
               
                if (arr[i]==a)
                { Console.Write(arr[i]+"+"+"\n"); }
                else { Console.Write(arr[i]+"\n"); }
                i = i + 1;
            }
        }
    }
}
