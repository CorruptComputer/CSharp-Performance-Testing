using System;
using PerformanceTesting.Util;

namespace PerformanceTesting.TestCases 
{
    public static class PropertyVSMember 
    {
        class PersonProperty {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }

        class PersonMember {
            public string FirstName;
            public string LastName;
            public int Age;
        }

        public static void RunTest() 
        {
            DateTime start, end;

            Console.WriteLine("# Starting 'Property' performance test...");
            start = DateTime.Now;
            for (int i = 0; i < 100000000; i++)
            {
                PersonProperty person = new PersonProperty() 
                {
                    FirstName = "Nickolas",
                    LastName = "Gupton",
                    Age = 22
                };
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 100,000,000 iterations it took: " + Utils.GetFormattedDuration(start, end));
            Console.WriteLine();
            

            Console.WriteLine("# Starting 'Member' performance test...");
            start = DateTime.Now;
            for (int i = 0; i < 100000000; i++)
            {
                PersonMember person = new PersonMember() 
                {
                    FirstName = "Nickolas",
                    LastName = "Gupton",
                    Age = 22
                };
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 100,000,000 iterations it took: " + Utils.GetFormattedDuration(start, end));


            Console.WriteLine();
            Console.WriteLine("Using Members instead of Properties can lead to a decent \n"
                              + "speed increase since there is not the additional overhead \n"
                              + "associated with the method calls for the getters and setters.");
        }
    }
}
