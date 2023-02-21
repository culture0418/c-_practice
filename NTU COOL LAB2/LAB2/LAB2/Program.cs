using System;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of citizens: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");
            int[] id = new int[n];
            // 產生一個Random
            Random rng = new Random();
            // 在id這個array裡面填入id號碼(從0~n-1)
            Console.Write("{0,9}", "id");
            for (int i = 0; i < n; i++)
            {
                id[i] = i;
                Console.Write("{0, 3}", id[i]);
            }
            Console.WriteLine();
            Console.Write("contactee");
            // shuffling algorithm
            for (int i = 0; i < id.Length - 1; i++)
            {
                int j = rng.Next(id.Length - i) + i;
                int tmp = id[i];
                id[i] = id[j];
                id[j] = tmp;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0, 3}", id[i]);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            // 在範圍0~n-1之間隨機產生一個亂數
            // 當作感染者
            int infected = rng.Next(n);
            Console.WriteLine("infected citizen: id = {0}", infected);
            int new_id = 0;
            Console.WriteLine("These citizens are to be self-isolated in the following 14 days: ");
            if (id[infected] != infected) 
            {
                new_id = id[infected];
                Console.Write("{0, 4}{1, 4}",infected, id[infected]);
            }
            while (id[new_id] != infected)
            {
                new_id = id[new_id];
                Console.Write("{0, 4}", new_id);
            }
            if (id[infected] == infected)
            {
                Console.Write("{0, 4}", id[infected]);
            }

        }
    }
}
