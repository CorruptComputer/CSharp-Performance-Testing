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
            string testStr1 = "";
            for (int i = 0; i < 10; i++)
            {
                testStr1 += (char)('a' + i % 26);
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 10 iterations it took: " + Utils.GetFormattedDuration(start, end));
            Console.WriteLine();


            Console.WriteLine("# Starting 'StringBuilder Concat Small' performance test...");
            start = DateTime.Now;
            StringBuilder testStrBuilder1 = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                testStrBuilder1.Append((char)('a' + i % 26));
            }
            string result1 = testStrBuilder1.ToString();
            end = DateTime.Now;
            Console.WriteLine("# Done. For 10 iterations it took: " + Utils.GetFormattedDuration(start, end));

            Console.WriteLine();
            Console.WriteLine("It is a common misconception that creating a StringBuilder \n"
                              + "to do concatination for a small number of iterations is \n"
                              + "slower due to the overhead of the Object creation. This is \n"
                              + "not true, and using a StringBuilder for even a small number \n"
                              + "of iterations can lead to a massive speed increase, even \n"
                              + "when you include the Object creation in the calculation of \n"
                              + "time.");
            Console.WriteLine(Utils.Seperator);
            Console.WriteLine();

            // String VS. StringBuilder Replacements for small lengths. Replaces every letter a-z.
            Console.WriteLine("# Starting 'String Replace Small' performance test...");
            start = DateTime.Now;
            for (int i = 0; i < 26; i++)
            {
                testStr1.Replace((char)('a' + i % 26), '-');
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 26 iterations it took: " + Utils.GetFormattedDuration(start, end));
            Console.WriteLine();


            Console.WriteLine("# Starting 'StringBuilder Replace Small' performance test...");
            start = DateTime.Now;
            for (int i = 0; i < 100000; i++)
            {
                testStrBuilder1.Replace((char)('a' + i % 26), '-');
            }
            string result2 = testStrBuilder1.ToString();
            end = DateTime.Now;
            Console.WriteLine("# Done. For 26 iterations it took: " + Utils.GetFormattedDuration(start, end));
            
            Console.WriteLine();
            Console.WriteLine("This speed benefit however does not extend to String \n"
                              + "replacements. StringBuilder is always slower than a String \n"
                              + "in this case.");
            Console.WriteLine(Utils.Seperator);
            Console.WriteLine();

            // String VS. StringBuilder Concatination for large iteration counts. Loops through letters a-z.
            Console.WriteLine("# Starting 'String Concat Large' performance test...");
            start = DateTime.Now;
            string testStr2 = "";
            for (int i = 0; i < 100000; i++)
            {
                testStr2 += (char)('a' + i % 26);
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 100,000 iterations it took: " + Utils.GetFormattedDuration(start, end));
            Console.WriteLine();


            Console.WriteLine("# Starting 'StringBuilder Concat Large' performance test...");
            start = DateTime.Now;
            StringBuilder testStrBuilder2 = new StringBuilder();
            for (int i = 0; i < 100000; i++)
            {
                testStrBuilder2.Append((char)('a' + i % 26));
            }
            string result3 = testStrBuilder2.ToString();
            end = DateTime.Now;
            Console.WriteLine("# Done. For 100,000 iterations it took: " + Utils.GetFormattedDuration(start, end));
            
            Console.WriteLine();
            Console.WriteLine("The speed difference between the two can be seen more easily \n"
                              + "on a larger scale. In this case the StringBuilder was an \n"
                              + "order of magnitude faster than the String when it came to \n"
                              + "concatination. This is because Strings in C# are immutable, \n"
                              + "and when you concatinate them it creates a new String and \n"
                              + "send the old one to be Garbage Collected. This excessive \n"
                              + "Garbage Collection has a very high overhead cost associated \n"
                              + "with it.");
            Console.WriteLine(Utils.Seperator);
            Console.WriteLine();

            // String VS. StringBuilder Replacements for large lengths. Replaces every letter a-z.
            Console.WriteLine("# Starting 'String Replace Large' performance test...");
            start = DateTime.Now;
            for (int i = 0; i < 26; i++)
            {
                testStr2.Replace((char)('a' + i % 26), '-');
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 26 iterations it took: " + Utils.GetFormattedDuration(start, end));
            Console.WriteLine();


            Console.WriteLine("# Starting 'StringBuilder Replace Large' performance test...");
            start = DateTime.Now;
            for (int i = 0; i < 26; i++)
            {
                testStrBuilder2.Replace((char)('a' + i % 26), '-');
            }
            string result4 = testStrBuilder2.ToString();
            end = DateTime.Now;
            Console.WriteLine("# Done. For 26 iterations it took: " + Utils.GetFormattedDuration(start, end));

            Console.WriteLine();
            Console.WriteLine("This last one I just added in for fun, but you can see how \n"
                              + "large the performance difference is between String and \n"
                              + "StringBuilder replacements. This just goes to show that the \n"
                              + "answer to String manipulation is NOT always to use a \n"
                              + "StringBuilder.");
        }
    }
}
