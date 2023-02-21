using System;

namespace MainDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in args)
            {
                Console.WriteLine(item);
            }
        }
    }
}
