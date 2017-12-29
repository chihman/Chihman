using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_14
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" введите данные ");
            string Q = Console.ReadLine();
            int i = 0, x = 0, b = 0, s = 0, j = 0;

            j = Q.Length;

            while (i < j)
            {//
                b = Q.IndexOf("[", i);
                int bb = Q.IndexOf("]", i);

                //
                x = Q.IndexOf("\"", i);
                if (x == i)
                {
                    if (x == i && s == 0)
                    {

                        Console.Write("[");
                    }

                    if (s == 1)
                    {

                        Console.Write("]");
                        s = 0;
                    }
                    s = s + 1;
                }



                else
                { //
                    if (b == i||bb==i)
                    {
                        String e = Q.Substring(i, 1);
                        Console.Write("\\"+e);

                     
                    }
                    //
                    else
                    {
                        String c = Q.Substring(i, 1);
                        Console.Write(c);
                    }
                }


                i = i + 1;

            }
        }
    }
}