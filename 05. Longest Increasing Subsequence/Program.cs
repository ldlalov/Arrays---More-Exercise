using System;
using System.Linq;

namespace _05._Longest_Increasing_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < myArray.Length; i++)
            {
                int[] newArray = new int[myArray.Length];
                newArray[i] = myArray[i];
                int minValue = int.MaxValue;
                int newIndex = 0;
                int minIndex = 0;
                for (int j = i+1; j < myArray.Length; j++)
                {
                    if (myArray[j]>newArray[i])
                    {
                        if (myArray[j]<minValue)
                        {
                            if (j>minIndex)
                            {
                                newArray[minIndex] = 0;
                                minIndex = j;
                        minValue = myArray[j];
                            }
                        }
                    }
                }
            }
        }
    }
}
