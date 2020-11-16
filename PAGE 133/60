using System;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int shir, lee, coin;
            shir = 0;
            lee = 0;
            for (; (lee != 3) && (shir != 3); ) 
            {
                Console.WriteLine("enter shir tree(1) or pali(2):");
                coin = int.Parse(Console.ReadLine());
                if (coin == 1)
                {
                    shir++;
                }
                Console.WriteLine("enter lee tree(1) or pali(2):");
                coin = int.Parse(Console.ReadLine());
                if (coin == 1)
                {
                    lee++;
                }
            }
            if (lee == 3)
                Console.WriteLine("lee won");
            else
                Console.WriteLine("shir won");
        }
    }
}
