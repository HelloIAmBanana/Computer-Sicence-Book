using System;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum;
            sum = 0;
            Console.WriteLine("enter number:");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
