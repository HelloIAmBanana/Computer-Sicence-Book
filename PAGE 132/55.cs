using System;
using System.Transactions;

namespace class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, num;
            Console.WriteLine("enter number");
            num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i = i + 2) 
            {
                Console.WriteLine(i);
                sum = sum + i;
            }
            Console.WriteLine("there sum was" + sum);
        }
    }
}
