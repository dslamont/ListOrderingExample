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

            ListOrderer orderer = new ListOrderer();

            //Console.WriteLine("");
            //Console.Write("Moved Up List = ");
            //List<char> movedUpList = orderer.MoveUp(testList, new List<int> { 3, 4 });
            //movedUpList.ForEach(Console.Write);
            //Console.WriteLine("");
            //Console.WriteLine("");

            Console.WriteLine("");
            List<char> movedDownList = orderer.MoveDown1(testList, new List<int> { 3, 4 });
            Console.Write("Moved Down List = ");
            movedDownList.ForEach(Console.Write);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
