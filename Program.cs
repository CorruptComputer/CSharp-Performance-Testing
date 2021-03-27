using System;
using PerformanceTesting.TestCases;
using PerformanceTesting.Util;

namespace PerformanceTesting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool loop = true;
            while(loop)
            {
                Console.Clear();
                Console.WriteLine("Please choose a performance test to run, or press any other key to exit.");
                Console.WriteLine("    1. Errors Throw VS. Errors Return");
                Console.WriteLine("    2. Classes VS. Structs");
                Console.WriteLine("    3. String VS. StringBuilder");
                Console.Write("> ");

                switch(Console.ReadKey().KeyChar) 
                {
                    case '1':
                        Console.WriteLine();
                        Console.WriteLine(Utils.Seperator);
                        ErrorsThrowVSErrorsReturn.RunTest();
                        break;
                    case '2':
                        Console.WriteLine();
                        Console.WriteLine(Utils.Seperator);
                        ClassesVSStructs.RunTest();
                        break;
                    case '3':
                        Console.WriteLine();
                        Console.WriteLine(Utils.Seperator);
                        StringVSStringBuilder.RunTest();
                        break;
                    default:
                        loop = false;
                        break;
                }

                if (loop)
                {
                    while(Console.KeyAvailable) 
                        Console.ReadKey(true);
                
                    Console.WriteLine(Utils.Seperator);
                    Console.WriteLine("Press 'Enter' to continue...");
                    Console.ReadLine();
                }
            }
        }
    }
}
