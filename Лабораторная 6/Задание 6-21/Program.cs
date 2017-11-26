using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Нажмите Y или N");
            //string selection = Console.ReadLine();
            //switch (selection)
            //{
            //   case "Y":
            //      Console.WriteLine("Вы нажали букву Y");
            //      break;
            //   case "N":
            ///        Console.WriteLine("Вы нажали букву N");
            //     break;
            //   default:
            //    Console.WriteLine("Вы нажали неизвестную букву");
            //      break;
            //} 


            Console.WriteLine("Вводимые данные:  ");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "10":
                    Console.WriteLine(" 10+ \n 11 \n 12 \n 13 \n 14 \n 15 \n 16 \n 17 \n 18 \n 19 \n 20");
                    break;
                case "11":
                    Console.WriteLine(" 10  \n 11+ \n 12 \n 13 \n 14 \n 15 \n 16 \n 17 \n 18 \n 19 \n 20");
                    break;
                case "12":
                    Console.WriteLine(" 10  \n 11 \n 12+ \n 13 \n 14 \n 15 \n 16 \n 17 \n 18 \n 19 \n 20 ");
                    break;
                case "13":
                    Console.WriteLine(" 10 \n 11 \n 12 \n 13+ \n 14 \n 15 \n 16 \n 17 \n 18 \n 19 \n 20");
                    break;
                case "14":
                    Console.WriteLine(" 10  \n 11 \n 12 \n 13 \n 14+ \n 15 \n 16 \n 17 \n 18 \n 19 \n 20");
                    break;
                case "15":
                    Console.WriteLine(" 10  \n 11 \n 12 \n 13 \n 14 \n 15+ \n 16 \n 17 \n 18 \n 19 \n 20 ");
                    break;
                case "16":
                    Console.WriteLine(" 10 \n 11 \n 12 \n 13 \n 14 \n 15 \n 16+ \n 17 \n 18 \n 19 \n 20");
                    break;
                case "17":
                    Console.WriteLine(" 10  \n 11 \n 12 \n 13 \n 14 \n 15 \n 16 \n 17+ \n 18 \n 19 \n 20");
                    break;
                case "18":
                    Console.WriteLine(" 10  \n 11 \n 12 \n 13 \n 14 \n 15 \n 16 \n 17 \n 18+ \n 19 \n 20 ");
                    break;
                case "19":
                    Console.WriteLine(" 10 \n 11 \n 12 \n 13 \n 14 \n 15 \n 16 \n 17 \n 18 \n 19+ \n 20");
                    break;
                case "20":
                    Console.WriteLine(" 10  \n 11 \n 12 \n 13 \n 14 \n 15 \n 16 \n 17 \n 18 \n 19 \n 20+");
                    break;



                default:
                    Console.WriteLine("Вы нажали неизвестную букву");
                    break;
            }
        }
    }
}
