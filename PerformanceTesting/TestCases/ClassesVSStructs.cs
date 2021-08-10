using System;
using PerformanceTesting.Util;

namespace PerformanceTesting.TestCases 
{
    public static class ClassesVSStructs 
    {
        class PersonClass {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }

        struct PersonStruct {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }

        public static void RunTest() 
        {
            DateTime start, end;

            Console.WriteLine("# Starting 'Class' performance test...");
            start = DateTime.Now;
            for (int i = 0; i < 100000000; i++)
            {
                PersonClass person = new() 
                {
                    FirstName = "Nickolas",
                    LastName = "Gupton",
                    Age = 22
                };
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 100,000,000 iterations it took: " + Utils.GetFormattedDuration(start, end));
            Console.WriteLine();


            Console.WriteLine("# Starting 'Struct' performance test...");
            start = DateTime.Now;
            for (int i = 0; i < 100000000; i++)
            {
                PersonStruct person = new() 
                {
                    FirstName = "Nickolas",
                    LastName = "Gupton",
                    Age = 22
                };
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 100,000,000 iterations it took: " + Utils.GetFormattedDuration(start, end));
        }
    }
}
