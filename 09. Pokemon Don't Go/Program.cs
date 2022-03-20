using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sumRemovedElements = 0;

            while (sequence.Count > 0)
            {
                int indexRemoval = int.Parse(Console.ReadLine());

                if (indexRemoval < 0)     // Greater or lower than element, insert/remove
                {
                    sumRemovedElements += sequence[0]; // remove element hence adding sum

                    int removedElementSum = sequence[0]; // saving value of FIRST element before removal

                    sequence.RemoveAt(0); // removing first element
                    sequence.Insert(0, sequence[sequence.Count - 1]);  // inserting value of last index on first element

                    for (int i = 0; i < sequence.Count; i++) // cycle to increase or decrease value on elements in index compared to the deleted sum
                    {
                        if (sequence[i] <= removedElementSum)
                        {
                            sequence[i] += removedElementSum;
                        }
                        else if (sequence[i] > removedElementSum)
                        {
                            sequence[i] -= removedElementSum;
                        }
                    }
                }
                else if (indexRemoval > sequence.Count - 1)
                {
                    sumRemovedElements += sequence[sequence.Count - 1]; // removing element hence adding sum

                    int removedElementSum = sequence[sequence.Count - 1]; // saving the value of the last index before removing it

                    sequence.RemoveAt(sequence.Count- 1);  // removing last element
                    sequence.Insert(sequence.Count, sequence[0]);     // inserting first on last with value of first


                    for (int i = 0; i < sequence.Count; i++) // cycle to increase or decrease value on elements in index compared to the deleted sum
                    {
                        if (sequence[i] <= removedElementSum)
                        {
                            sequence[i] += removedElementSum;
                        }
                        else if (sequence[i] > removedElementSum)
                        {
                            sequence[i] -= removedElementSum;
                        }
                    }
                }
                else
                {

                    for (int i = 0; i < sequence.Count; i++)
                    {
                        if (i == indexRemoval) // if both indexes meet during the loop jump over the one for removal
                        {
                            continue;
                        }

                        if (sequence[i] <= sequence[indexRemoval]) // if lower than the element of the removing index ADD sum
                        {
                            sequence[i] += sequence[indexRemoval];
                        }
                        else if (sequence[i] > sequence[indexRemoval]) // if higher than the element of the removing index SUBTRACT sum
                        {
                            sequence[i] -= sequence[indexRemoval];
                        }
                    }

                    sumRemovedElements += sequence[indexRemoval]; // adding sum from the element of the removable index
                    sequence.RemoveAt(indexRemoval); // removing the index
                }
            }

            Console.WriteLine(sumRemovedElements);
        }
    }
}
