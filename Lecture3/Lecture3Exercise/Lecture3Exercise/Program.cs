using System;

namespace Lecture3Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // 題目：隨機產生3個變數，找出最大值
            // TODO
            // (1) 產生3個變數
            Random rng = new Random();
            int n1 = rng.Next(-50, 51);
            int n2 = rng.Next(-50, 51);
            int n3 = rng.Next(-50, 51);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            // (2) 找出最大值
            int max = 0;
            if (n1 >= max)
                max = n1;
            if (n2 >= max)
                max = n2;
            if (n3 >= max)
                max = n3;
            Console.WriteLine("Maximum is {0}", max);

        }
    }
}
