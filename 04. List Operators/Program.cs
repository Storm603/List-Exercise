using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numList = Console.ReadLine().Split().Select(int.Parse).ToList();
            string line = String.Empty;

            while (true)
            {

                line = Console.ReadLine();
                string[] command = line.Split();

                if (command[0] == "End")
                {
                    Console.WriteLine(string.Join(" ", numList));
                    return;
                }

                if (command[0] == "Add")
                {
                    numList.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    if (int.Parse(command[2]) >= numList.Count || int.Parse(command[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numList.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                else if (command[0] == "Remove")
                {
                    if (int.Parse(command[1]) >= numList.Count || int.Parse(command[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numList.RemoveAt(int.Parse(command[1]));
                }
                else if (command[1] == "left" && command[0] == "Shift")
                {
                    for (int i = 0; i < int.Parse(command[2]); i++)
                    {
                        numList.Insert(numList.Count, numList[0]);
                        numList.RemoveAt(0);
                    }
                }
                else if (command[1] == "right" && command[0] == "Shift")
                {
                    for (int i = 0; i < int.Parse(command[2]); i++)
                    {
                        numList.Insert(0, numList[numList.Count - 1]);
                        numList.RemoveAt(numList.Count - 1);
                    }
                }
            }
        }
    }
}
