using System;

namespace Lecture4Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // 計算10! = ?
            int sum = 1;
            int i = 1;
            for (i = 1; i <= 10; i++)
            {
                sum = sum * i;
            }
            Console.WriteLine("sum = {0}", sum);
        }
    }
}
