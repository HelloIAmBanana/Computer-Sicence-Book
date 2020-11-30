using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, count = 0;
            Console.WriteLine("enter number");
            num1 = int.Parse(Console.ReadLine());
            while (num1 >= 0)
            {
                Console.WriteLine("enter number");
                num1 = int.Parse(Console.ReadLine());
                count++;
            }
            Console.WriteLine("number of positive numbers:" + count);
            Console.ReadLine();
                   
        }
    }
}
