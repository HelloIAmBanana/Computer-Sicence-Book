using System;
using System.Transactions;

namespace class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double time, time1 = 999999999, time2 = 999999999;
            int n;
            Console.WriteLine("how many cars");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine("enter time");
                time = double.Parse(Console.ReadLine());
                if (time < time1)
                {
                    time2 = time1;
                    time1 = time;
                }
                else
                {
                    if (time < time2)
                        time2 = time;
                }
            }
            Console.WriteLine("the first place time was: " + time1);
            Console.WriteLine("the second place time was: " + time2);
        }
    }
}
