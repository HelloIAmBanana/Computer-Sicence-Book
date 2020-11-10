using System;
using System.Transactions;

namespace class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2 =0;
            double avg = 0;
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("enter number");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter another number");
                num2 = int.Parse(Console.ReadLine());
                avg = avg + Math.Max(num1, num2);
            }
            avg = avg / 20;
            Console.WriteLine("avarage is:" + avg);
        }
    }
}
