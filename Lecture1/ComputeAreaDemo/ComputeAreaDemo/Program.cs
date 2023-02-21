using System;

namespace ComputeAreaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 變數第一次出現的時候都要宣告變數

            //input
            Console.WriteLine("Enter a radius:");
            int r = int.Parse(Console.ReadLine()); // 宣告變數r是一個整數
            if (r > 0)
            {
                // algorithm
                double A = r * r * 3.14; //宣告變數A是一個浮點數
                // output
                Console.WriteLine(A);
            }
            else
            {
                Console.WriteLine("It is not a radius.");
            }
            
           
            //Console.WriteLine(3.14 + 1e20 - 1e20); 
            //Console.WriteLine(3.14 + (1e20 - 1e20)); // 寫 code 寫這種形式，小括弧內會先做
        }
    }
}
