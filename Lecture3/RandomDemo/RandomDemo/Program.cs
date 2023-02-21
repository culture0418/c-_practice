using System;

namespace RandomDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 題目：產生兩個隨機變數，問使用者相加的結果，判斷是否正確
            // TODO
            // (1) generate two random numbers
            Random rng = new Random(); // new 產生一個新物件 Random，再透過 rng 來呼叫函數 Next()
            int x = rng.Next(10);
            int y = rng.Next(10);
            // (2) show the question
            Console.WriteLine("{0} + {1} = ?", x, y);
            // (3) input the ans
            Console.WriteLine("Enter your answer:");
            int ans = int.Parse(Console.ReadLine());
            // (4) judge the input
            if (ans == (x + y))
            {
                Console.WriteLine("Right Answer.");
                Console.WriteLine("You answer 1 time.");
            }
            //else
            //{
            //    Console.WriteLine("Wrong Answer.");
            //    Console.WriteLine("The correct answer is {0}", x + y);
            //}
            int t = 1;
            while (ans != (x + y))
            {
                Console.WriteLine("Wrong Answer.");
                ans = int.Parse(Console.ReadLine());
                t = t + 1;
            }
            Console.WriteLine("Correct.");
            Console.WriteLine("You answer {0} times.", t);
        }
    }
}
