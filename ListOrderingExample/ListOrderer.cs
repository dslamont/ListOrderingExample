using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOrderingExample
{
    /// <summary>
    /// Class to facilitate the reordering of lists
    /// </summary>
    public class ListOrderer
    {
        public List<char> MoveUp(List<char> origList, List<int> indexes)
        {
            List<char> result = new List<char>(origList);

            foreach (int index in indexes)
            {
                char tempChar = result[index - 1];
                result[index - 1] = result[index];
                result[index] = tempChar;
            }

            return result;
        }

        public List<char> MoveDown1(List<char> origList, List<int> indexes)
        {
            Console.WriteLine("MoveDown1");
            List<char> result = new List<char>(origList);


            List<int> reorderedIndexes = indexes.OrderByDescending(i => i).ToList<int>();
            foreach (int index in reorderedIndexes)
            {
                Console.WriteLine($"Moving {result[index]} down");
            }

            foreach (int index in reorderedIndexes)
            {
                char tempChar = result[index + 1];
                result[index + 1] = result[index];
                result[index] = tempChar;
            }

            return result;
        }

        public List<char> MoveDown2(List<char> origList, List<int> indexes)
        {
            Console.WriteLine("MoveDown2");
            List<char> result = new List<char>(origList);


            List<int> reorderedIndexes = indexes.OrderByDescending(i => i).ToList<int>();
            foreach (int index in reorderedIndexes)
            {
                Console.WriteLine($"Moving {result[index]} down");
            }

            foreach (int index in reorderedIndexes)
            {
                if (index < origList.Count)
                {
                    Console.WriteLine($"Replacing {result[index + 1]}  with {result[index]}");
                    char tempChar = result[index + 1];
                    result[index + 1] = result[index];
                    result[index] = tempChar;
                    result.ForEach(Console.Write);
                    Console.WriteLine("");
                }
            }

            
            return result;
        }

    }
}
