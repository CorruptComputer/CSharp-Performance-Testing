using System;
using System.Text;
using PerformanceTesting.Util;

namespace PerformanceTesting.TestCases 
{
    public static class StringVSStringBuilder 
    {
        public static void RunTest() 
        {
            DateTime start, end;

            // String VS. StringBuilder Concatination for small iteration counts. Loops through letters a-z.
            Console.WriteLine("# Starting 'String Concat Small' performance test...");
            start = DateTime.Now;
            string testStrSmall = "";
            for (int i = 0; i < 10; i++)
            {
                testStrSmall += (char)('a' + i % 26);
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 10 iterations it took: " + Utils.GetFormattedDuration(start, end));
            Console.WriteLine();


            Console.WriteLine("# Starting 'StringBuilder Concat Small' performance test...");
            start = DateTime.Now;
            StringBuilder testStrBuilderSmall = new();
            for (int i = 0; i < 10; i++)
            {
                testStrBuilderSmall.Append((char)('a' + i % 26));
            }
            string result1 = testStrBuilderSmall.ToString();
            end = DateTime.Now;
            Console.WriteLine("# Done. For 10 iterations it took: " + Utils.GetFormattedDuration(start, end));
            Console.WriteLine();

            // String VS. StringBuilder Replacements for small lengths. Replaces every letter a-z.
            Console.WriteLine("# Starting 'String Replace Small' performance test...");
            start = DateTime.Now;
            for (int i = 0; i < 26; i++)
            {
                testStrSmall = testStrSmall.Replace((char)('a' + i % 26), '-');
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 26 iterations it took: " + Utils.GetFormattedDuration(start, end));
            Console.WriteLine();


            Console.WriteLine("# Starting 'StringBuilder Replace Small' performance test...");
            start = DateTime.Now;
            for (int i = 0; i < 26; i++)
            {
                testStrBuilderSmall.Replace((char)('a' + i % 26), '-');
            }
            string result2 = testStrBuilderSmall.ToString();
            end = DateTime.Now;
            Console.WriteLine("# Done. For 26 iterations it took: " + Utils.GetFormattedDuration(start, end));
            Console.WriteLine();


            // String VS. StringBuilder Concatination for large iteration counts. Loops through letters a-z.
            Console.WriteLine("# Starting 'String Concat Large' performance test...");
            start = DateTime.Now;
            string testStrLarge = "";
            for (int i = 0; i < 100000; i++)
            {
                testStrLarge += (char)('a' + i % 26);
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 100,000 iterations it took: " + Utils.GetFormattedDuration(start, end));
            Console.WriteLine();


            Console.WriteLine("# Starting 'StringBuilder Concat Large' performance test...");
            start = DateTime.Now;
            StringBuilder testStrBuilderLarge = new();
            for (int i = 0; i < 100000; i++)
            {
                testStrBuilderLarge.Append((char)('a' + i % 26));
            }
            string result3 = testStrBuilderLarge.ToString();
            end = DateTime.Now;
            Console.WriteLine("# Done. For 100,000 iterations it took: " + Utils.GetFormattedDuration(start, end));
            Console.WriteLine();

            // String VS. StringBuilder Replacements for large lengths. Replaces every letter a-z.
            Console.WriteLine("# Starting 'String Replace Large' performance test...");
            start = DateTime.Now;
            for (int i = 0; i < 26; i++)
            {
                testStrLarge = testStrLarge.Replace((char)('a' + i % 26), '-');
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 26 iterations it took: " + Utils.GetFormattedDuration(start, end));
            Console.WriteLine();


            Console.WriteLine("# Starting 'StringBuilder Replace Large' performance test...");
            start = DateTime.Now;
            for (int i = 0; i < 26; i++)
            {
                testStrBuilderLarge.Replace((char)('a' + i % 26), '-');
            }
            string result4 = testStrBuilderLarge.ToString();
            end = DateTime.Now;
            Console.WriteLine("# Done. For 26 iterations it took: " + Utils.GetFormattedDuration(start, end));
        }
    }
}
