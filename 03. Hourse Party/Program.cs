using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Hourse_Party
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> nameList = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split().ToArray();

                if (commands[2] == "going!" && nameList.Contains(commands[0]))
                {
                    Console.WriteLine($"{commands[0]} is already in the list!");
                }
                else if(commands[2] == "going!")
                {
                    nameList.Add(commands[0]);
                }

                if (commands[2] == "not" && nameList.Contains(commands[0]))
                {
                    nameList.Remove(commands[0]);
                }
                else if(commands[2] == "not")
                {
                    Console.WriteLine($"{commands[0]} is not in the list!");
                }
                //commands = Console.ReadLine().Split().ToArray();
            }

            for (int i = 0; i < nameList.Count; i++)
            {
                Console.WriteLine(nameList[i]);
            }
        }
    }
}
