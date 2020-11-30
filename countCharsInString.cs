using System;
using System.Collections.Generic;

namespace countCharsInString
{
    class countCharsInString
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
              

            Dictionary<char, int> counts = new Dictionary<char, int>();

            for (int i = 0; i < words.Length; i++)
            {
                char letter = words[i];

                if (letter != ' ')
                {

                    if (!counts.ContainsKey(letter))
                    {
                        counts.Add(letter, 1);
                    }
                    else
                    {
                        counts[letter]++;
                    }
                }
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
