using System;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num1, num2, num3, sum;
            sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("enter 3 digits number");
                num = int.Parse(Console.ReadLine());
                num2 = (num % 100) / 10;
                num3 = num % 10;
                num1 = num / 100;
                if (num2 == num1 || num2 == num3 || num3 == num1)
                {
                    sum++;
                    Console.WriteLine(num);
                }
            }
            Console.WriteLine("there were {0} with the same 2 digits", sum);
        }
    }
}
