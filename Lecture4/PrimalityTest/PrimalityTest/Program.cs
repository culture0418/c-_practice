using System;

namespace PrimalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // 質數檢查
            // 檢查 0 ~ 100的質數
            Random rng = new Random();
            int s = rng.Next(101);
            Console.WriteLine(s);
            for (int i = 2; i <= Math.Pow(s, 0.5); i++)
            {
                if (s % i == 0)
                {
                    break;
                }
            }
        }
    }
}
