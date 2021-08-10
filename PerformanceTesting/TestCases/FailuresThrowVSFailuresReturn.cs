using System;
using PerformanceTesting.Util;

namespace PerformanceTesting.TestCases 
{
    public static class FailuresThrowVSFailuresReturn 
    {
        public static string ErrorThrows(string str) 
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str), "str cannot be null!");
            }

            return str + "foo";
        }

        public static string ErrorReturns(string str) 
        {
            if (str == null)
            {
                return null;
            }

            return str + "foo";
        }

        public static void RunTest() 
        {
            DateTime start, end;

            Console.WriteLine("# Starting 'Failure Throws' performance test...");
            start = DateTime.Now;
            for (int i = 0; i < 100000; i++)
            {
                try
                {
                    string result = ErrorThrows(null);
                }
                catch (ArgumentNullException)
                {
                    // Handle the error
                }
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 100,000 iterations it took: " + Utils.GetFormattedDuration(start, end));
            Console.WriteLine();


            Console.WriteLine("# Starting 'Failure Returns' performance test...");
            start = DateTime.Now;
            for (int i = 0; i < 100000; i++)
            {
                string result = ErrorReturns(null);

                if (result == null)
                {
                    // Handle the error
                }
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 100,000 iterations it took: " + Utils.GetFormattedDuration(start, end));
        }
    }
}
