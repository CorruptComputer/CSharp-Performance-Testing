using System;
using System.Collections;
using System.Collections.Generic;
using PerformanceTesting.TestData;
using PerformanceTesting.Util;

namespace PerformanceTesting.TestCases
{
    public static class KeyValuePairTypes
    {
        private record Person(string FirstName, string LastName, int Age);

        public static void RunTest()
        {
            DateTime start, end;

            Console.WriteLine("# Starting 'Dictionary' performance test...");
            start = DateTime.Now;
            Dictionary<string, Person> dictionary = new();
            for (int i = 0; i < 100000; i++)
            {
                dictionary.Add(i.ToString(), new Person(PersonData.FirstName, PersonData.LastName, PersonData.Age));
            }

            for (int i = 0; i < 100000; i++)
            {
                dictionary.TryGetValue(i.ToString(), out Person p);
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 100,000 iterations it took: " + Utils.GetFormattedDuration(start, end));
            Console.WriteLine();

            Console.WriteLine("# Starting 'SortedDictionary' performance test...");
            start = DateTime.Now;
            SortedDictionary<string, Person> sortedDictionary = new();
            for (int i = 0; i < 100000; i++)
            {
                sortedDictionary.Add(i.ToString(), new Person(PersonData.FirstName, PersonData.LastName, PersonData.Age));
            }

            for (int i = 0; i < 100000; i++)
            {
                sortedDictionary.TryGetValue(i.ToString(), out Person p);
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 100,000 iterations it took: " + Utils.GetFormattedDuration(start, end));
            Console.WriteLine();

            Console.WriteLine("# Starting 'Hashtable' performance test...");
            start = DateTime.Now;
            Hashtable hashtable = new();
            for (int i = 0; i < 100000; i++)
            {
                hashtable.Add(i.ToString(), new Person(PersonData.FirstName, PersonData.LastName, PersonData.Age));
            }

            for (int i = 0; i < 100000; i++)
            {
                Person p = (Person)hashtable[i.ToString()];
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 100,000 iterations it took: " + Utils.GetFormattedDuration(start, end));
            Console.WriteLine();

            Console.WriteLine("# Starting 'SortedList' performance test...");
            start = DateTime.Now;
            SortedList<string, Person> sortedList = new();
            for (int i = 0; i < 100000; i++)
            {
                sortedList.Add(i.ToString(), new Person(PersonData.FirstName, PersonData.LastName, PersonData.Age));
            }

            for (int i = 0; i < 100000; i++)
            {
                sortedList.TryGetValue(i.ToString(), out Person p);
            }
            end = DateTime.Now;
            Console.WriteLine("# Done. For 100,000 iterations it took: " + Utils.GetFormattedDuration(start, end));
        }
    }
}

