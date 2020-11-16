using System;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit1, digit2, digit3, count, sum;
            count = 0;
            for (int i = 100; i <= 999; i++)
            {
                digit1 = i / 100;
                digit2 = (i % 100) / 10;
                digit3 = i % 10;
                sum = digit1 + digit2 + digit3;
                if (i % sum == 0)  
                {
                    count++;
                }
            }
            Console.WriteLine("there were {0} numbers", count);
        }
    }
}
