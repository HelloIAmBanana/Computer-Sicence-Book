A.
5
4
3
2
1

B.
using System;
using System.Transactions;

namespace class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5, a = 0;
            for (int i = 0; i < n; i++)
            {
                a = n - i;
                Console.WriteLine(a);
            }
        }
    }
}
