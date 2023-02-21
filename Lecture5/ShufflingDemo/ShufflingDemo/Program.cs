using System;

namespace ShufflingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] A = { "A", "B", "C", "D", "E" };
            Random rng = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                int j = rng.Next(A.Length);
                string tmp = A[i];
                A[i] = A[j];
                A[j] = tmp;
                // 為什麼我將console.WriteLine()寫在for迴圈裡的時候會出現重複的情況
                Console.WriteLine("A[{0}] = {1}", i, A[i]);
            }
            foreach (string items in A)
            {
                Console.WriteLine("{0, 2}", items);
            }
            
        }
    }
}
