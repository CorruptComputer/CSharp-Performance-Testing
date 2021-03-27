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

            Console.WriteLine("Starting 'Class' performance test...");
            start = DateTime.Now;
            for (int i = 0; i < 100000000; i++)
            {
                PersonClass person = new PersonClass() 
                {
                    FirstName = "Nickolas",
                    LastName = "Gupton",
                    Age = 22
                };
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 100,000,000 iterations it took: " + Utils.GetFormattedDuration(start, end));
            Console.WriteLine();


            Console.WriteLine("Starting 'Struct' performance test...");
            start = DateTime.Now;
            for (int i = 0; i < 100000000; i++)
            {
                PersonStruct person = new PersonStruct() 
                {
                    FirstName = "Nickolas",
                    LastName = "Gupton",
                    Age = 22
                };
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 100,000,000 iterations it took: " + Utils.GetFormattedDuration(start, end));

            Console.WriteLine();
            Console.WriteLine("In C# it is a common design practice to hold multiple pieces \n"
                              + "of data in a single container Class that has no methods \n"
                              + "associated with it. These can be changed to use a Struct \n"
                              + "in order to gain additional performance from your \n"
                              + "application. Classes have additional overhead associated \n"
                              + "with their creation that Structs do not, which leads to a \n"
                              + "performance difference between the two.");
        }
    }
}
