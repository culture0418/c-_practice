using System;

namespace NTU_COOL_LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            int low = 0, high = 99;
            Random rng = new Random();
            int s = rng.Next(100);
            // Console.WriteLine(s);
            while (true)
            {
                Console.WriteLine("({0}, {1})?", low, high);
                int g = int.Parse(Console.ReadLine());
                // 防呆機制
                if (g > high || g < low)
                {
                    Console.WriteLine("Out of range. Try again!");
                    continue;
                }

                if (g == s)
                {
                    Console.WriteLine("bingo!");
                    break;
                }

                else if (g > s)
                {
                    high = g - 1;
                    if (low == high)
                    {
                        Console.WriteLine("GG");
                        break;
                    }
                    Console.WriteLine("Too large.");
                }

                else
                {
                    low = g + 1;
                    if (low == high)
                    {
                        Console.WriteLine("GG");
                        break;
                    }
                    Console.WriteLine("Too small.");
                    
                }
            }
        }
    }
}
