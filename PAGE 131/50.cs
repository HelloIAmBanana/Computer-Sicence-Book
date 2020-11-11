using System;
using System.Transactions;

namespace class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 0, max = 0, oldnum=0;
            int intnum = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("enter number");
                num = double.Parse(Console.ReadLine());
                intnum = (int)num;
                num = num - intnum;
                if (max < num)
                {
                    oldnum = intnum+num;
                }

            }
            Console.WriteLine("the max number was:"+oldnum);
        }
    }
}
