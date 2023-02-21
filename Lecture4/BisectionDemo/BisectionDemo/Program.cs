using System;

namespace BisectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 用二元搜尋法找方程式的根
            // 方程式 x ^ 3 - x -2 = 0
            double a = 1, b = 2, c = 0, eps = 1e-9;
            while (b - a > eps)
            {
                c = (a + b) / 2;
                double fa = a * a * a - a - 2;
                double fb = b * b * b - b - 2;
                double fc = c * c * c - c - 2;

                // 往左邊找答案
                if (fa * fc < 0)
                {
                    b = c;
                }
                // 往右邊找答案
                else
                {
                    a = c;
                }
            }
            double residual = c * c * c - c - 2;
            Console.WriteLine("Root ~ {0}",c);
            Console.WriteLine("residual = {0}", residual);
        }
    }
}
