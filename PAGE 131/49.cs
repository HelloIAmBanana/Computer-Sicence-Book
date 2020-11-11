using System;
using System.Transactions;

namespace class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double height, newheight;
            int student, newstudent;
            height = 0;
            student = 0;
            for (int i = 1; i <= 8; i++)
            {
                Console.WriteLine("enter jump height");
                newheight = double.Parse(Console.ReadLine());
                Console.WriteLine("enter student number");
                newstudent = int.Parse(Console.ReadLine());
                if (height < newheight)
                {
                    height = newheight;
                    student = newstudent;
                }

            }
            Console.WriteLine("the highest jump was {0} by student number {1}", height, student);
        }
    }
}
