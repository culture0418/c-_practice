using System;

namespace FactorialDemo
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n > 0)
            {
                return n * Factorial(n - 1);
            }
            else
            {
                return 1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("10! = {0}", Factorial(10));
        }
    }
}
