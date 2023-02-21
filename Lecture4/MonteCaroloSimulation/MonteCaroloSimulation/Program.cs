using System;

namespace MonteCaroloSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // 基本概念
            // 假設現在有一個邊長為1的正方形，在裡面畫出半徑為1的1/4圓
            // 投擲100000次飛鏢有幾次會落在1/4圓裡面：m
            // m / N = 3.14 / 4
            int N = 100000;
            int i = 0;
            int m = 0;
            // 隨機產生一組變數(x, y)
            Random rng = new Random();
            for (i = 0; i < N; i++)
            {
                double x = rng.NextDouble();
                double y = rng.NextDouble();
                // 判斷落在圓內還是圓外
                if (x * x + y * y  < 1)
                {
                    m++;
                }
            }
            Console.WriteLine(4.0 * m / N);
            // tips 這裡要記得打4.0 才不會讓 datatype 自動轉成 int !!!
        }
    }
}
