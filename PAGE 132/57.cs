using System;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int book, price, sum, total;
            sum = 0;
            Console.WriteLine("enter notebook price");
            price = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("how many notebook you bought?");
                book = int.Parse(Console.ReadLine());
                sum = sum + book;
            }
            total = sum * price;
            Console.WriteLine("you bought {0} notebooks for the price of {1}", sum, total);
        }
    }
}
