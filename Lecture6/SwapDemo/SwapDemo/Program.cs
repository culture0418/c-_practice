using System;

namespace SwapDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int u = 10, v = 20;
            Console.WriteLine("{0}, {1}", u, v);
            Swap(ref u, ref v);
            Console.WriteLine("{0}, {1}", u, v);
        }
        static void Swap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }
    }
}
