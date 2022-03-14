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
            Console.WriteLine("請輸入一個數字");
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
            }
            Console.ReadKey();
        }
    }
}

