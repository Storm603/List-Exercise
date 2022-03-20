using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ").ToList();

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "3:1")
            {
                if (command[0] == "merge")
                {
                    string added = String.Empty;
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    if (endIndex > input.Count - 1)
                    {
                        endIndex = input.Count - 1;
                    }

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    int count = 0;
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        if (count >= 1)
                        {
                            input[startIndex] += input[i];
                            //input.RemoveAt(i);
                            //i--;
                        }
                        count++;
                    }
                    input.RemoveRange(startIndex + 1, count - 1);
                }

                command = Console.ReadLine().Split().ToArray();






            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
