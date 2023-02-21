using System;

namespace Lecture4Exercuse_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // input number
            Console.WriteLine("輸入底數:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("輸入指數:");
            double n = double.Parse(Console.ReadLine());

            // check fundamental rules
            if (x <= 0)
            {
                Console.WriteLine("Wrong input");
            }
            int sum = 0;
            sum = (int)Math.Pow(x, n);
            Console.WriteLine("sum = {0}", sum);
            
        }
    }
}
