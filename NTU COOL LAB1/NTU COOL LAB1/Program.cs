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
            Console.WriteLine(s);
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
                    // 讓電腦自己隨便猜，計算他猜了幾次
                    /*int low = 0, high = 99;
                    Random rng = new Random();
                    int s = rng.Next(100);
                    Console.WriteLine(s);
                    int n = 0;
                    while (true)
                    {
                        //Console.WriteLine("({0}, {1})?", low, high);
                        int g = rng.Next(low, high + 1);

                        if (g == s)
                        {
                            //Console.WriteLine("bingo!");
                            n++;
                            break;
                        }

                        else if (g > s)
                        {
                            high = g - 1;
                            if (low == high)
                            {
                                //Console.WriteLine("GG");
                                break;
                            }
                            //Console.WriteLine("Too large.");
                            n++;
                        }

                        else
                        {
                            low = g + 1;
                            if (low == high)
                            {
                                //Console.WriteLine("GG");
                                break;
                            }
                            //Console.WriteLine("Too small.");
                            n++;
                        }
                    }
                    Console.WriteLine("guess how many times:{0}", n);*/
                }
            }
        }
    }
}
