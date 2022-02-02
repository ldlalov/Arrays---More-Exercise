using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondArray = new int[firstArray.Length / 4];
            int[] thirdArray = new int[firstArray.Length / 4];
            int[] fourthArray = new int[firstArray.Length / 2];
            int[] fifththArray = new int[firstArray.Length / 2];
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = firstArray[i];
                thirdArray[i] = firstArray[firstArray.Length - 1-i];
            }
            for (int i = 0;i<secondArray.Length*2;i++)
            {
                fourthArray[i] = firstArray[i+secondArray.Length];
            }
                secondArray = secondArray.Reverse().ToArray();
            for (int i = 0; i < secondArray.Length; i++)
            {
                fifththArray[i] = secondArray[i]+fourthArray[i];
            }
            for (int i = secondArray.Length; i < fourthArray.Length; i++)
            {
                fifththArray[i] = thirdArray[i - thirdArray.Length] + fourthArray[i];
            }
            Console.WriteLine(String.Join(' ', fifththArray));
        }
    }
}
