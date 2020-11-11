using System;
using System.Transactions;

namespace class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1, letter2;
            int sum =0;
            Console.WriteLine("enter letter");
            letter1 = char.Parse(Console.ReadLine());
            for (int i = 1; i < 25; i++)
            {
                Console.WriteLine("enter letter");
                letter2 = char.Parse(Console.ReadLine());
                if (letter1 == letter2)
                    sum++;
            }
            Console.WriteLine("there were {0} same letters like the first one", sum);
        }
    }
}
