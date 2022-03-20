using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> split = Console.ReadLine().Split("|").Reverse().ToList();
            List<int> reversed = new List<int>();


            foreach (var str in split)
            {
                reversed.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            Console.WriteLine(string.Join(" ", reversed));
        }
    }
}
