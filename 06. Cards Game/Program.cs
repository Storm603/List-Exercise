using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> p1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> p2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                if (!p1.Any() || !p2.Any())
                {
                    break;
                }
                if (p1[0] == p2[0])
                {
                    p1.RemoveAt(0);
                    p2.RemoveAt(0);
                }
                else if (p1[0] > p2[0])
                {
                    p1.Add(p2[0]);
                    p1.Add(p1[0]);
                    p1.RemoveAt(0);
                    p2.RemoveAt(0);
                }
                else if (p2[0] > p1[0])
                {
                    p2.Add(p1[0]);
                    p2.Add(p2[0]);
                    p1.RemoveAt(0);
                    p2.RemoveAt(0);
                }
            }

            if (!p1.Any())
            {
                Console.WriteLine($"Second player wins! Sum: {p2.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {p1.Sum()}");

            }
        }
    }
}
