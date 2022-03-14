using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220314
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("請輸入一個數字");
              string str1 = Console.ReadLine();
              int num1 = Convert.ToInt32(str1);

              if (num1 % 2 != 0)
              {
                  Console.WriteLine("Weird");
              }
              else if (num1 >= 2 && num1 <= 5)
              {
                  Console.WriteLine("Not Weird");
              }
              else if (num1 >= 6 && num1 <= 20)
              {
                  Console.WriteLine("Weird");
              }
              else
              {
                  Console.WriteLine("Not Weird");
              }*/

            //練習一
            Console.Write("請輸入N : ");
            string str2 = Console.ReadLine();
            int num2 = Convert.ToInt32(str2);

            Console.WriteLine();

            for (int x = 1; x <= num2; x++)
            {
                for (int y = 1; y <= x; y++)

                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //練習二
            Console.Write("請輸入N : ");
            string str3 = Console.ReadLine();
            int num3 = Convert.ToInt32(str3);

            Console.WriteLine();

            for (int y = 1; y <= num3; y++)

            {
                Console.WriteLine(num3 + "*" + y + "=" + (num3 * y));
            }

            Console.WriteLine();

            //練習三

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)

                {
                    Console.WriteLine(i + "*" + j + "=" + (i * j));
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}




