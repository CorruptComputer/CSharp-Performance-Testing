using System;

namespace PerformanceTesting.Util 
{
    public static class Utils 
    {
        public static string Seperator = "============================================================";

        public static string GetFormattedDuration(DateTime start, DateTime end) 
        {
            TimeSpan duration = end - start;

            if (duration.TotalSeconds > 1)
            {
                return duration.TotalSeconds + " seconds";
            }
            else
            {
                return duration.TotalMilliseconds + " milliseconds";
            }
        }
    }
}
