using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (bomb[1] < 0)
            {
                return;
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb[0])
                {
                    i -= bomb[1];
                    int annihilation = (bomb[1] * 2) + 1;
                    if (i + annihilation > numbers.Count)
                    {
                        int range = Math.Abs((annihilation - i));
                        numbers.RemoveRange(i, range);
                    }
                    else if (i < 0)
                    {
                        if (i > numbers.Count)
                        {
                            return;
                        }
                        int range = i + annihilation;
                        numbers.RemoveRange(0, range);
                        i = -1;
                    }
                    else
                    {
                        numbers.RemoveRange(i, annihilation);
                    }
                    //numbers.RemoveAt(i);
                    //i++;
                    //if (numbers[i] + bomb[1] > numbers.Count - 1)
                    //{
                    //    int range = numbers.Count - i;
                    //    //i--;
                    //    numbers.RemoveRange(i, range);
                    //    //numbers.RemoveAt(numbers.Count - 1);
                    //}
                    //else
                    //{
                    //    numbers.RemoveRange(i, bomb[1]);
                    //}
                    //i -= bomb[1];
                    //numbers.RemoveRange(i, bomb[1]);
                    //i = 0;
                }


            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
