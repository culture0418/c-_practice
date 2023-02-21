using System;

namespace Lecture4Exercuse_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a endpoint");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);
            int i = 0;
            double p = 0;
            for (i = 0; i < n; i++)
            {
                p = p + Math.Pow(-1, i) /(2 * i + 1);
            }
            p = p * 4;
            Console.WriteLine("p = {0}", p);
        }
    }
}
