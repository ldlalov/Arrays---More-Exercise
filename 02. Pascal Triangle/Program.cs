using System;

namespace _02._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int val = 1;
            for (int i = 0; i < rows;i++)
            {
                for (int j = 0;j<=i;j++)
                {
                    if (j == 0 || i == 0)
                        val = 1;
                    else
                        val = val * (i - j + 1) / j;
                    Console.Write($"{val} ");
                }
                Console.WriteLine();
            }
        }
    }
}
