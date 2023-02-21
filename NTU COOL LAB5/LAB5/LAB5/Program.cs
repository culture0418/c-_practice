using System;

namespace LAB5
{
    interface Play
    {
        int next(int low, int high);
    }
    abstract class Player : Play
    {
        String name { get; set; }
        public abstract int next(int low, int high);

    }
    class NaiveAI : Player
    {
        public override int next(int low, int high)
        {
            return new Random().Next(low, high + 1);
        }
    }
    class BinarySearchAI: NaiveAI
    {
        public override int next(int low, int high)
        {
            return (low + high) / 2;
        }
    }
    class SuperAI : NaiveAI
    {
        public override int next(int low, int high)
        {
            return low;
        }
    }
    class HumanPlayer : Player
    {
        string name { get; set; }
        public override int next(int low, int high)
        {
            return int.Parse(Console.ReadLine());
        }
    }
    
    
    class Game
    {
        Player player;
        int s, low = 0, high = 99;

        public Game(Player player)
        {
            this.player = player;
            Random rng = new Random();
            s = rng.Next(100);
        }

        public void run()
        {
            while (true)
            {
                Console.WriteLine("({0}, {1})?", low, high);
                int g = player.next(low, high);
                Console.WriteLine("{0}", g);
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
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            new Game(new SuperAI()).run();
        }
    }
}
