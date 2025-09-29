namespace FindOccurrences
{
    public class FindOccurrence
    {
        /// <summary>
        ///methods to find the occurances of a pattern in a text
        /// </summary>
        /// <param name="text"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public List<int> FindSubstringOccurrences(string text, string pattern)
        {
            List<int> positions = new List<int>();
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(pattern))
                return positions;

            for (int i = 0; i <= text.Length - pattern.Length; i++)
            {
                if (text.Substring(i, pattern.Length) == pattern)
                    positions.Add(i);
            }

            return positions;
        }
        /// <summary>
        /// method to display the result
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="positions"></param>
        public void DisplayResults(string pattern, List<int> positions)
        {
            if (positions.Count > 0)
            {
                Console.WriteLine($"Substring '{pattern}' occurred {positions.Count} times.");
                Console.WriteLine("Index positions: " + string.Join(" ", positions));
            }
            else
            {
                Console.WriteLine($"Substring '{pattern}' not found.");
            }
        }

    }
}
