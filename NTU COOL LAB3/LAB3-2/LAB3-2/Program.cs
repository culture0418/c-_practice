using System;
using System.Diagnostics;

namespace LAB3-2
{
    class Program
    {
        
static void TableFactory()
        {
            Console.WriteLine("Benckmark (time units: ms)");
            Console.Write("{0, 7}", "Size");
            foreach (string title in titles)
                Console.Write("{0, 7}", title);
            Console.WriteLine();

            for (int i = 0; i < data_size.Length; i++)
            {
                Console.Write("{0, 7}", data_sizes[i]);
                for (int j = 0; j < titles.Length; j++)
                {
                    Console.Write("{0, 17:f2}", tb1[j, i]);

                }
            }

        }
        static int[] ArrayFactory(int N)
        {
            int[] A = new int[N];
            Random rng = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rng.Next(100);
            }
            return A;
        }

        static void Display(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("{0} ", A[i]);
            }
            Console.WriteLine();
        }
        static void Swap(ref int u, ref int v)
        {
            int tmp = u;
            u = v;
            v = tmp;
        }
        // bubble sorting
        static void BubbleSort(int[] A)
        {
            for (int j = 0; j < A.Length; j++)
            {
                for (int i = 0; i < A.Length - 1; i++)
                {
                    if (A[i] >= A[i + 1])
                    {
                        Swap(ref A[i], ref A[i + 1]);
                    }
                }
            }
        }
        //selection sort
        static void SelectionSort(int[] A)
        {

            int[] A2 = ArrayFactory(10);
            for (int i = 0, minindex; i < A2.Length - 1; i++)
            {
                minindex = i;
                for (int j = i + 1; j < A2.Length; j++)
                {
                    if (A2[j] < A2[minindex])
                    {
                        minindex = j;
                    }
                }
                Swap(ref A2[minindex], ref A2[i]);
            }
        }
        static void InsertionSort(int[] A)
        {
            // Insertion Sort
            int[] A3 = ArrayFactory(10);

            for (int i = 1; i < A3.Length; i++)
            {
                int num = A3[i];
                for (int j = i; j >= 0; j--)
                {
                    if (num < A3[j])
                    {
                        A3[j + 1] = A3[j];
                        A3[j] = num;
                    }
                }
            }
        }
        static void Simulate(int id)
        {
            public int[] data_size = new int[7];
    data_size[0] = 1000;
        for (int i = 1; i<data_size.Length; i++)
        {
            data_size[i] = 1000 * (i + 1);
        }
string[] titles = new string[4];
            titles[0] = "Bubble Sort";
            titles[1] = "Selection Sort";
            titles[2] = "Insertion Sort";
            titles[3] = "Array.Sort";


            for (int i = 0; i < data_size.Length; i++)
            {
                for (int j = 1; j <= titles.Length; j++)
                {
                    int[] A = ArrayFactory(data_size[i]);
                    Stopwatch time = new Stopwatch;
                    time.Start();
                    switch (id)
                    {
                        case 0:
                            BubbleSort(A);
                            break;
                        case 1:
                            SelectionSort(A);
                            break;
                        case 2:
                            InsertionSort(A);
                            break;
                        case 3:
                            Array.Sort(A);
                            break;
                    }
                    timer.Stop();



                }
            }
        }
        static void Main(string[] args)
        {
            int[] data_size = new int[7];
            data_size[0] = 1000;
            for (int i = 1; i < data_size.Length; i++)
            {
                data_size[i] = 1000 * (i + 1);
            }

        }
    }
}
