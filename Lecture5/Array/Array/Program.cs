using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;

            // generate an int array, size = N
            int[] A = new int[N];
            // Fill intergers to A
            Random rng = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rng.Next(100);
            }
            // Display all elements of A 
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("{0} ", A[i]);
            }
            // 換行
            Console.WriteLine();
            // Find the maximum of A
            int max = A[0];
            int loc = 0;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                    loc = i;
                }
            }
            Console.WriteLine("MAX = {0} at {1}", max, loc);

            // sum of A
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
            }
            Console.WriteLine("sum = {0}", sum); 
            
        }
    }
}
