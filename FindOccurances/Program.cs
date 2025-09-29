using System;
using System.Collections.Generic;

using System;
namespace FindOccurrences { 

public class Program
    {
        public static void Main()
        {
            Console.Write("Enter the first string (S1): ");
            string inputString = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter the second string (S2): ");
            string searchString = Console.ReadLine() ?? string.Empty;

            FindOccurrence obj = new FindOccurrence();
            List<int> occurrences = obj.FindSubstringOccurrences(inputString, searchString);
            obj.DisplayResults(searchString, occurrences);
        }
    }
}
