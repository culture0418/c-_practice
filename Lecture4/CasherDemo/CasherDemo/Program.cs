using System;

namespace CasherDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // write a program which sums over positive intergers from consecutive inputs 
            // and then output the sum when the input is nonpositive
            int price = 0, total = 0;
            Console.WriteLine("Enter your price.");
            price = int.Parse(Console.ReadLine());
            while (price > 0)
            {
                total = total + price;
                Console.WriteLine("Enter your next price.");
                price = int.Parse(Console.ReadLine());
            }
            // 當輸入金額 <= 0,當作他已經輸入完成，印出總金額
            Console.WriteLine("Total = {0}", total);
        }
    }
}
