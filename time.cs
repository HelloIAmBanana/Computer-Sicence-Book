using System;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec = 0, min = 0, hour = 0;
            double mil = 0;
            while (hour <= 24)
            {
                for (; mil <= 145000000;)
                {
                    mil++;
                    if (mil == 145000000)
                    {
                        mil = 0;
                        sec++;
                        Console.WriteLine("_________");
                        Console.WriteLine("| {0}:{1}:{2} |", hour, min, sec);
                        Console.WriteLine("_________");

                    }
                    if (sec == 60)
                    {
                        min++;
                        sec = 0;
                        Console.WriteLine("_________");
                        Console.WriteLine("| {0}:{1}:{2} |", hour, min, sec);
                        Console.WriteLine("_________");

                    }
                    if (min == 60)
                    {
                        hour++;
                        min = 60;
                        Console.WriteLine("_________");
                        Console.WriteLine("| {0}:{1}:{2} |", hour, min, sec);
                        Console.WriteLine("_________");

                    }
                }
            }
        }
    }
}
