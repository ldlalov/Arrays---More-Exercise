using System;
using System.Linq;

namespace LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladybugSpaces = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            int[] field = new int[fieldSize];

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < ladybugSpaces.Length; j++)
                {
                    if (ladybugSpaces[j] == i)
                    {
                        field[i] = 1;
                    }
                }
            }

            while (input != "end")
            {
                string[] command = input.Split().ToArray();
                int index = int.Parse(command[0]);
                string direction = command[1];
                int flyLength = int.Parse(command[2]);

                for (int i = 0; i < fieldSize; i++)
                {
                    if (i == index)
                    {
                        if (direction == "right")
                        {
                            if (i + flyLength < fieldSize)
                            {
                                for (int j = i + flyLength; j < fieldSize; j += flyLength)
                                {
                                    if (j >= fieldSize)
                                    {
                                        field[i] = 0;
                                        break;
                                    }
                                    else if (field[j] == 0)
                                    {
                                        field[j] = 1;
                                        field[i] = 0;
                                        break;
                                    }

                                }
                            }
                            else
                            {
                                field[i] = 0;
                            }
                        }
                        else if (direction == "left")
                        {
                            if (i - flyLength >= 0)
                            {
                                for (int j = i - flyLength; j > 0; j -= flyLength)
                                {
                                    if (j < 0)
                                    {
                                        field[i] = 0;
                                        break;
                                    }
                                    else if (field[j] == 0)
                                    {
                                        field[j] = 1;
                                        field[i] = 0;
                                        break;
                                    }

                                }
                            }
                            else
                            {
                                field[i] = 0;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", field));
        }
    }
}