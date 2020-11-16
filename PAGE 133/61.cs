using System;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum;
            string bitoy = "1";
            sum = 1;
            Console.WriteLine("enter number");
            num = int.Parse(Console.ReadLine());
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                    bitoy += "+" + i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine("the number {0} is a perfect number: {1}={0}", num, bitoy);
            }
        }
    }
}
