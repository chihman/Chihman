using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводимые данные:  ");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "30":
                    Console.WriteLine("  30+ \n 31- \n 32- \n 33- \n 34- \n 35- \n 36- \n 37- \n 38- \n 39- \n 40-");
                    break;
                case "31":
                    Console.WriteLine(" 30- \n 31+ \n 32- \n 33- \n 34- \n 35- \n 36- \n 37- \n 38- \n 39- \n 40- ");
                    break;
                case "32":
                    Console.WriteLine(" 30- \n 31- \n 32+ \n 33- \n 34- \n 35- \n 36- \n 37- \n 38- \n 39- \n 40- ");
                    break;
                case "33":
                    Console.WriteLine(" 30- \n 31- \n 32- \n 33+ \n 34- \n 35- \n 36- \n 37- \n 38- \n 39- \n 40- ");
                    break;
                case "34":
                    Console.WriteLine(" 30- \n 31- \n 32- \n 33- \n 34+ \n 35- \n 36- \n 37- \n 38- \n 39- \n 40- ");
                    break;
                case "35":
                    Console.WriteLine("  30- \n 31- \n 32- \n 33- \n 34- \n 35+ \n 36- \n 37- \n 38- \n 39- \n 40- ");
                    break;
                case "36":
                    Console.WriteLine("  30- \n 31- \n 32- \n 33- \n 34- \n 35- \n 36+ \n 37- \n 38- \n 39- \n 40-");
                    break;
                case "37":
                    Console.WriteLine("  30- \n 31- \n 32- \n 33- \n 34- \n 35- \n 36- \n 37+ \n 38- \n 39- \n 40- ");
                    break;
                case "38":
                    Console.WriteLine("  30- \n 31- \n 32- \n 33- \n 34- \n 35- \n 36- \n 37- \n 38+ \n 39- \n 40-");
                    break;
                case "39":
                    Console.WriteLine("  30- \n 31- \n 32- \n 33- \n 34- \n 35- \n 36- \n 37- \n 38- \n 39+ \n 40-");
                    break;
                case "40":
                    Console.WriteLine("  30- \n 31- \n 32- \n 33- \n 34- \n 35- \n 36- \n 37- \n 38- \n 39- \n 40+");
                    break;



                default:
                    Console.WriteLine(" 30- \n 31- \n 32- \n 33- \n 34- \n 35- \n 36- \n 37- \n 38- \n 39- \n 40-");
                    break;
            }
        }
    }
}
