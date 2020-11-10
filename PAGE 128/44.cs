using System;
using System.Transactions;

namespace class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, hezka,total;
            Console.WriteLine("enter number");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("enter hezka");
            hezka = int.Parse(Console.ReadLine());
            total = num;
            for (int i = 2; i <= hezka; i++)
            {
                total = total * num;
            }
            Console.WriteLine("your number is:" + total);
        }
    }
}
