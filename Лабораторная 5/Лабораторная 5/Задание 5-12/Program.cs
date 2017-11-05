using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_12
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


            Console.WriteLine("Введите символ:  ");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "a":
                    Console.WriteLine(" a+ \n b \n c \n d \n e \n f \n g \n h ");
                    break;
                case "b":
                    Console.WriteLine(" a \n b+ \n c \n d \n e \n f \n g \n h ");
                    break;
                case "c":
                    Console.WriteLine(" a \n b \n c+ \n d \n e \n f \n g \n h ");
                    break;
                case "d":
                    Console.WriteLine(" a \n b \n c \n d+ \n e \n f \n g \n h ");
                    break;
                case "e":
                    Console.WriteLine(" a \n b \n c \n d \n e+ \n f \n g \n h ");
                    break;
                case "f":
                    Console.WriteLine(" a \n b \n c \n d \n e \n f+ \n g \n h ");
                    break;
                case "g":
                    Console.WriteLine(" a \n b \n c \n d \n e \n f \n g+ \n h ");
                    break;
                case "h":
                    Console.WriteLine(" a\n b \n c \n d \n e \n f \n g \n h+ ");
                    break;

                    
                default:
                    Console.WriteLine("Вы нажали неизвестную букву");
                    break;
            }
        


        }
    }
}
