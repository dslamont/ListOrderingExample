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
        public List<char> MoveDown(List<char> origList, List<int> indexes)
        {
            List<char> result = new List<char>(origList);

            foreach (int index in indexes)
            {
                char tempChar = result[index + 1];
                result[index + 1] = result[index];
                result[index] = tempChar;
            }

            return result;
        }

    }
}
