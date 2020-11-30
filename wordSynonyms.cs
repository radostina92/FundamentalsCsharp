using System;
using System.Collections.Generic;

namespace wordSynonyms
{
    class wordSynonyms
    {
        static void Main(string[] args)
        {
            var words = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());
            string word = string.Empty;
            string synonym = string.Empty;
            for (int i = 0; i < n; i++)
            {
                word = Console.ReadLine();
                synonym = Console.ReadLine();

                if (!words.ContainsKey(word))
                {
                    words[word] = new List<string>();

                }
                words[word].Add(synonym);

            }

            if (words.ContainsKey("task"))
            {
                foreach (var item in words)
                {
                    Console.Write($"{item.Key} – ");
                    Console.WriteLine(string.Join(", ", item.Value));
                }
            }
            else
            {

                foreach (var item in words)
                {
                    Console.Write($"{item.Key} - ");
                    Console.WriteLine(string.Join(", ", item.Value));
                }
            }
        }
    }
}
