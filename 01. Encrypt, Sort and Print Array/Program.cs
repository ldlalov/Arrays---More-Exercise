using System;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                char [] name = Console.ReadLine().ToCharArray();
                foreach (char character in name)
                {
                    if (character == 65 || character == 69 || character == 73 || character == 79 || character == 85 || character == 97 || character == 101 || character == 105 || character == 111 || character == 117)
                    {
                        sum += character * name.Length;
                    }
                    else
                    {
                        sum += character / name.Length;
                    }
                }
                result[i] = sum;
            }
            Array.Sort(result);
            foreach (var cell in result)
            {
                Console.WriteLine(cell);
            }
        }
    }
}
