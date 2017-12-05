using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string input = "abcdefwxyz";
            if (input.Contains(a))
            { Console.Write("Содержит"); }
            else { Console.Write("не Содержит"); }
        }
    }
}
