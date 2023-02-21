using System;
using System.Diagnostics;

namespace LAB3
{
    class Algorithm
    {
        // bubble sorting
        public static void BubbleSort(int[] A)
        {
            for (int j = 0; j < A.Length; j++)
            {
                for (int i = 0; i < A.Length - 1; i++)
                {
                    if (A[i] >= A[i + 1])
                    {
                        Program.Swap(ref A[i], ref A[i + 1]);
                    }
                }
            }
        }
        //selection sort
        public static void SelectionSort(int[] A)
        {
            for (int i = 0, minindex; i < A.Length - 1; i++)
            {
                minindex = i;
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] < A[minindex])
                    {
                        minindex = j;
                    }
                }
                Program.Swap(ref A[minindex], ref A[i]);
            }
        }
        // Insertion Sort
        public static void InsertionSort(int[] A)
        {
            for (int i = 1; i < A.Length; i++)
            {
                int num = A[i];
                for (int j = i; j >= 0; j--)
                {
                    if (num < A[j])
                    {
                        A[j + 1] = A[j];
                        A[j] = num;
                    }
                }
            }
        }
    }
    class Display
    {
        public static void DisplayArray(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("{0} ", A[i]);
            }
            Console.WriteLine();
        }
    }
    class Factory
    {
        public static int[] ArrayFactory(int N)
        {
            int[] A = new int[N];
            Random rng = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rng.Next(100);
            }
            return A;
        }
    }
    
    class Program
    {
        public static void Swap(ref int u, ref int v)
        {
            int tmp = u;
            u = v;
            v = tmp;
        }
        static void Main(string[] args)
        {

            int[] data_sizes = new int[7];
            string[] titles = new string[5];
                titles[0] = "Size";
                titles[1] = "Bubble Sort";
                titles[2] = "Selective Sort";
                titles[3] = "Insertion Sort";
                titles[4] = "Array Sort";
            for (int k = 0; k < titles.Length; k++)
            {

                Console.Write("{0, 20}", titles[k]);
            }
            Console.WriteLine();
            for (int i = 0; i < data_sizes.Length; i++)
            {
                if (i == 0)
                {
                    data_sizes[i] = 1000;
                }
                else
                {
                    data_sizes[i] = data_sizes[i - 1] * 2;
                }
                
                int N = data_sizes[i];
                int[] A = Factory.ArrayFactory(N);
                double[] second = new double[4];
                
                Stopwatch time = new Stopwatch();
                for (int id = 0; id < 4; id++)
                {
                    time.Start();
                    switch (id)
                    {
                        case 0:
                            Algorithm.BubbleSort(A);
                            break;
                        case 1:
                            Algorithm.SelectionSort(A);
                            break;
                        case 2:
                            Algorithm.InsertionSort(A);
                            break;
                        case 3:
                            Array.Sort(A);
                            break;
                    }
                    time.Stop();
                    double sec = 1000.0 * time.ElapsedTicks / Stopwatch.Frequency;
                    second[id] = sec;
                }
                Console.Write("{0, 20}", data_sizes[i]);

                for (int j = 0; j < second.Length; j++)
                {
                    
                    Console.Write("{0, 20}", second[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
