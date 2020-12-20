using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOrderingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("");


            List<char> testList = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            PrintList(testList, "Original List = ");

            //Console.Write("Original  List = ");
            //testList.ForEach(Console.Write);
            //Console.WriteLine("");

            List<int> indexesToMove = new List<int> { 3, 4 };
            List<char> charsToMove = new List<char>();
            Console.Write("Indexes of Chars to move down = ");
            foreach (int i in indexesToMove)
            {
                charsToMove.Add(testList[i]);
            }
            charsToMove.ForEach(Console.Write);
            Console.WriteLine("");
            Console.WriteLine("");

            ListOrderer orderer = new ListOrderer();
            List<char> movedDownList = orderer.MoveDown(testList, indexesToMove);
            Console.Write("Moved Down List = ");
            movedDownList.ForEach(Console.Write);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    
        private static void PrintList(List<char> list, string header)
        {
            Console.Write(header);
            list.ForEach(Console.Write);
            Console.WriteLine("");
        }
    }
}
