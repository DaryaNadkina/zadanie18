using System;

namespace _18
{
    class Program
    {
        const int n = 5, m = 5;
        static void Main()
        {
            int[,] array = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rand.Next(1, 11);
                    Console.Write("{0,3}", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    if (i == 0 || i == n - 1 || j == 0 || j == m - 1)
                        Console.Write("{0,3}", array[i, j]);
                else
                        Console.Write("   ");
                Console.WriteLine();
            }
        }
    }
}
