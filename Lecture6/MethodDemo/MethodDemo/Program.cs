using System;

namespace MethodDemo
{
    class Program
    {
        // 找出最大值的函式
        public static int Max(int[] A)
        {
            int maxnumber = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > maxnumber)
                {
                    maxnumber = A[i];
                }
            }
            return maxnumber;
        }


        // 加總的函式
        public static int Sum(int[] A)
        {
            int result = 0;
            for (int i = 0; i < A.Length; i++)
            {
                result += A[i];
            }
            return result;
        }
        
        // 
        public static void Display(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("{0} ", A[i]);
            }
            Console.WriteLine("");
        }
        
        public static int[] ArrayFactory(int size, int low, int high) // inculsive
        {
            int[] A = new int[size];
            Random rng = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rng.Next(low, high + 1);
            }
            return A;
        }
        static void Main(string[] args)
        {
            int[] A = ArrayFactory(10, -100, 100);
            Display(A);
            Console.WriteLine("Max = {0}", Max(A));
        }
    }
}
