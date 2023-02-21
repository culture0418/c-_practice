using System;

namespace Exercise5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 產生一個整數矩陣 A 大小52
            string[] number = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" };
            string[] color = { "black", "heart", "squre", "flower" };
            int[] A = new int[52];
            for (int i = 1; i < A.Length; i++)
            {
                A[i] = i;
            }
            Random rng = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                int j = rng.Next(A.Length - i) + i;
                int tmp = A[i];
                A[i] = A[j];
                A[j] = tmp;
            }
            for (int i = 0; i < 5; i++)
            {
                int turn = (A[i] / 13);
                int sequence = (A[i] % 13) + 1;
                Console.Write(A[i]);
                Console.WriteLine("{0, 7} {1, 3}", color[turn], number[sequence]);
            }
        }
    }
}
