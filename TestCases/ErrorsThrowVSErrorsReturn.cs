using System;
using PerformanceTesting.Util;

namespace PerformanceTesting.TestCases 
{
    public static class ErrorsThrowVSErrorsReturn 
    {
        public static string ErrorThrows(string str) 
        {
            if (str == null)
            {
                throw new ArgumentNullException("str1", "str1 cannot be null!");
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

            Console.WriteLine("# Starting 'Error Throws' performance test...");
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


            Console.WriteLine("# Starting 'Error Returns' performance test...");
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

            Console.WriteLine();
            Console.WriteLine("Throwing Exceptions in C# is very costly in terms of run \n"
                              + "time. This additional overhead can have a massive impact on \n"
                              + "runtime of your application. Keeping Exceptions to an \n"
                              + "absolute minimum should be a priority if performance is \n"
                              + "important. Instead of throwing an exception when something \n"
                              + "isn't quite right but the application can still continue to \n"
                              + "run anyways is a lot better of a design than throwing and \n"
                              + "catching Exceptions.");
        }
    }
}
