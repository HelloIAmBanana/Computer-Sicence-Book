using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum, machpela;
            sum = 0;
            Console.WriteLine("enter number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter another number");
            num2 = int.Parse(Console.ReadLine());
            machpela = num1 * num2;
            sum = sum + machpela;
            while (machpela != 0)
            {
                Console.WriteLine("enter number");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter another number");
                num2 = int.Parse(Console.ReadLine());
                machpela = num1 * num2;
                sum = sum + machpela;
            }
            if (sum >= 0)
                Console.WriteLine("the sum is " + sum+" and its positive");
            else
                Console.WriteLine("the sum is " + sum+" and its negative");
            Console.ReadLine();
                   
        }
    }
}
