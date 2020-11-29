using System;
using System.Collections.Generic;

namespace ListOrderingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("");


            List<char> testList = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

            Console.Write("Original  List = ");
            testList.ForEach(Console.Write);

            Console.WriteLine("");
            Console.Write("Reordered List = ");
            ListOrderer orderer = new ListOrderer();
            List<char> reorderedList = orderer.MoveUp(testList, new List<int> { 3, 4 });
            reorderedList.ForEach(Console.Write);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
