using System;

namespace GlobalLocalvariale
{
    class Program
    {
        static int x = 10;
        static void Main(string[] args)
        {
            int x = 100;
            x = x + 1;
            Console.WriteLine(x);
            AddOne();
            Console.WriteLine(x);
        }
        public static void AddOne()
        {
            x = x + 1;
            Console.WriteLine(x);
        }
    }
}
