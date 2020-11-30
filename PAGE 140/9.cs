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
            int grade, maxGrade, MinGrade;
            Console.WriteLine("enter grade");
            grade = int.Parse(Console.ReadLine());
            MinGrade = grade;
            maxGrade = grade;
            while (grade >= 0)
            {
                if (grade >= 95)
                    Console.WriteLine("excellence passed");
                if (grade < 55) 
                    Console.WriteLine("failed");
                if (maxGrade < grade)
                    maxGrade = grade;
                if (MinGrade > grade)
                    MinGrade = grade;
                Console.WriteLine("enter grade");
                grade = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("the highest grade was " + maxGrade);
            Console.WriteLine("the lowest grade was " + MinGrade);
            Console.ReadLine();
                   
        }
    }
}
