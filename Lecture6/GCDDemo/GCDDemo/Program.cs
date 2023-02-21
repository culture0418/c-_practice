using System;

namespace GCDDemo
{
    class Program
    {
        static int GCD(int a, int b)
        {
            int r = a % b;
            if (r != 0)
            {
                return GCD(b, r);
            }
            else
            {
                return b;
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("GCD(54, 32) = {0}", GCD(54, 32));
        }
    }
}
