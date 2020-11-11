using System;
using System.Transactions;

namespace class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, smallnum, newsmallnum;
            int pair=1;
            Console.WriteLine("enter number");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter another number");
            num2 = double.Parse(Console.ReadLine());
            smallnum = Math.Min(num1, num2);
            for (int i = 1; i <= 99; i++)
            {
                Console.WriteLine("enter number");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("enter another number");
                num2 = double.Parse(Console.ReadLine());
                newsmallnum = Math.Min(num1, num2);
                if (newsmallnum < smallnum) 
                {
                    pair = i;
                    smallnum = newsmallnum;
                }
                    
            }
            Console.WriteLine("the lowest number was: " + smallnum);
            Console.WriteLine("the pair number was:" + pair);
        }
    }
}
