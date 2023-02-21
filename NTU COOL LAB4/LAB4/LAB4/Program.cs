using System;

namespace LAB4
{
    class Program
    {
        static double Pow(double x, int n)
        {
            if ( n == 0)
            {
                return 1;
            }
            int m = n;
            if (n < 0)
            {
                m = -m;
            }
            double y = Pow(x, m / 2);
            y = y * y;
            if (m % 2 == 1)
            {
                y = y * x;
            }
            return n > 0 ? y : 1 / y;
            // n > 0 return y, n < 0 return 1 / y
        }
        
        
        static void Main(string[] args)
        {
            for (int i = -10; i < 11; i++)
            {
                double x = 2;
                Console.WriteLine("{0, 1} ^ {1, 3} = {2}", x, i, Pow(x, i));
            }
            
        }
    }
}
