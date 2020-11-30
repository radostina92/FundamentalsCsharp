using System;
using System.Collections.Generic;

namespace oddOccurrences
{
    class oddOccurrences
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordInLower = word.ToLower();

                if (counts.ContainsKey(wordInLower))
                {
                    counts[wordInLower]++;
                }
                else
                {
                    counts.Add(wordInLower, 1);
                }

            }

            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
