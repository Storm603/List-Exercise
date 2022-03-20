using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxWagonCapacity = int.Parse(Console.ReadLine());
            string[] insertPeople = Console.ReadLine().Split().ToArray();

            while (insertPeople[0] != "end")
            {
                if (insertPeople.Length == 1)
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (int.Parse(insertPeople[0]) + wagons[i] <= maxWagonCapacity)
                        {
                            wagons[i] += int.Parse(insertPeople[0]);
                            break;
                        }
                    }
                }
                else if (insertPeople.Length == 2)
                {
                    wagons.Add(int.Parse(insertPeople[1]));
                }
                insertPeople = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
