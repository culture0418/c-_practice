using System;

namespace NTUCOOLLAB1AIGUESS
{
    class Program
    {
        static void Main(string[] args)
        {
            // 讓電腦自己猜 
            int low = 0, high = 99;
            Random rng = new Random();
            int s = rng.Next(100);
            int N = 10, m = 0;
            for (int i = 0; i < N; i++)
            {
                while (true)
                {
                    // 二元搜尋法
                    int g = (low + high) / 2;
                    Console.WriteLine(g);

                    if (g == s)
                    {
                        // Console.WriteLine("bingo!");
                        m++;
                        break;
                    }

                    else if (g > s)
                    {
                        high = g - 1;
                        // Console.WriteLine("Too large.");
                    }

                    else
                    {
                        low = g + 1;
                        // Console.WriteLine("Too small.");
                    }
                    if (low == high)
                    {
                        // Console.WriteLine("GG");
                        break;
                    }
                }
            }
            Console.WriteLine("winning rate = {0}%", m * 100.0 / N);
        }
    }
}
