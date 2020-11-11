using System;
using System.Transactions;

namespace class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 0, max = -999999999999999999, min = 9999999999999999999;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("enter number");
                num = double.Parse(Console.ReadLine());
                if (num >= 0)
                {
                    if (min > num)
                        min = num;
                }
                else
                {
                    if (max < num) 
                        max = num;
                }
                    
            }
            Console.WriteLine("the max negetive number was {0} and the lowest positive number was {1}",max,min);
        }
    }
}
