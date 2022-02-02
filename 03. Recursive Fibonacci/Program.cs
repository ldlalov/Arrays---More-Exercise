using System;

namespace _03._Recursive_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3=0, i, number;
            number = int.Parse(Console.ReadLine());
            for (i = 2; i <= number; ++i)  
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
            }
            if (number == 1)
            {
                n3 = 1;
            }
            Console.WriteLine(n3);
        }
    }
}
