using System;
using System.Collections.Generic;

namespace PerformanceTesting.TestData
{
    public static class PersonData
    {
        private static readonly Random rdm = new();

        private static readonly List<string> FirstNames = new()
        {
            "Nickolas",
            "Marlon",
            "Yurem",
            "Jamie",
            "Lucas",
            "Leanna",
            "Roger",
            "River",
            "Duncan",
            "Jaxson",
            "Brogan",
            "Konnor",
            "Sarah",
            "Tatiana",
            "Mathias",
            "Kira",
            "Andre",
            "Zayne",
            "Tia",
            "Christine",
            "Chandler"
        };

        private static readonly List<string> LastNames = new()
        {
            "Gupton",
            "Macdonald",
            "Jimenez",
            "Valenzuela",
            "Yates",
            "Brewer",
            "Duke",
            "Mooney",
            "Fischer",
            "Wilkins",
            "Berry",
            "Best",
            "Bishop",
            "Hawkins",
            "Mcclain",
            "Richmond",
            "Gardner",
            "Long",
            "Velazquez",
            "Dunlap",
            "Barker"
        };

        public static string FirstName
        {
            get => FirstNames[rdm.Next(0, FirstNames.Count)];
        }

        public static string LastName
        {
            get => LastNames[rdm.Next(0, LastNames.Count)];
        }

        public static int Age
        {
            get => rdm.Next(0, 100);
        }
    }
}
