using System;
using System.Linq;
using System.Collections.Generic;
using PerformanceTesting.Util;

namespace PerformanceTesting.TestCases 
{
    public static class ForVSForEach 
    {
        public static void RunTest() 
        {
            DateTime start, end;
            // Setup our initial data.
            int[] intArray = new int[100000000];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i;
            }
            List<int> intList = intArray.ToList();

            Console.WriteLine("# Starting 'Array For' performance test...");
            start = DateTime.Now;
            for (int i = 0; i < intArray.Length; i++)
            {
                int someInt = intArray[i];
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 100,000,000 iterations it took: " + Utils.GetFormattedDuration(start, end));
            Console.WriteLine();


            Console.WriteLine("# Starting 'Array ForEach' performance test...");
            start = DateTime.Now;
            foreach (int i in intArray)
            {
                int someInt = i;
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 100,000,000 iterations it took: " + Utils.GetFormattedDuration(start, end));

            Console.WriteLine(Utils.Seperator);

            Console.WriteLine("# Starting 'List For' performance test...");
            start = DateTime.Now;
            for (int i = 0; i < intArray.Length; i++)
            {
                int someInt = intArray[i];
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 100,000,000 iterations it took: " + Utils.GetFormattedDuration(start, end));
            Console.WriteLine();


            Console.WriteLine("# Starting 'List ForEach' performance test...");
            start = DateTime.Now;
            foreach (int i in intArray)
            {
                int someInt = i;
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 100,000,000 iterations it took: " + Utils.GetFormattedDuration(start, end));



            Console.WriteLine();
            Console.WriteLine("The difference between For and ForEach loops are negligable, \n"
                              + "and will vary from run to run on which is faster.");
        }
    }
}
