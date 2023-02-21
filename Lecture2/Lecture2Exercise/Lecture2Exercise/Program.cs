using System;

namespace Lecture2Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // write a program which takes 3 numbers as user input, and calculates the average with standard deviation
            // input
            Console.WriteLine("Please enter the first number:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the third number:");
            double x3 = double.Parse(Console.ReadLine());
            // algorithm
            double avg = (x1 + x2 + x3) / 3;
            double sum = Math.Pow((x1 - avg), 2) + Math.Pow((x2 - avg), 2) + Math.Pow((x3 - avg), 2);
            double stv = Math.Sqrt(sum);
            // output
            Console.WriteLine(stv);
        }
    }
}
