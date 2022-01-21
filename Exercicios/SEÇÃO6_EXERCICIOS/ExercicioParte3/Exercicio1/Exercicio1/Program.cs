using System;
namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int search = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mat[i, j] == search)
                    {
                        Console.WriteLine($"Position {i},{j}:");
                        if (j - 1 >= 0)
                        {
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }
                        if (j + 1 < m)
                        {
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        }
                        if (i + 1 < n)
                        {
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }
                        if (i - 1 >= 0)
                        {
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }
                    }
                }
            }
        }
    }
}