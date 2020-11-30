using System;
using System.Collections.Generic;
using System.Linq;

namespace theFinalQuest222
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();


            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] arguments = command.Split();
                string first = arguments[0];
                if (first == "Delete")
                {
                    int index = int.Parse(arguments[1]);

                    if (index >= 0 && index + 1 < words.Count)
                    {
                        words.RemoveAt(index + 1);
                    }
                }
                else if (first == "Swap")
                {
                    string word1 = arguments[1];
                    string word2 = arguments[2];

                    if (words.Contains(word1) && words.Contains(word2))
                    {
                        int index = words.IndexOf(word1);
                        int index2 = words.IndexOf(word2);
                        words[index] = word2;
                        words[index2] = word1;
                    }
                }
                else if (first == "Put")
                {
                    string word = arguments[1];
                    int index = int.Parse(arguments[2]);

                    if (index > 0 && index <= words.Count)//moje da gurmi zaradi posledniq index
                    {
                        words.Insert(index - 1, word);
                    }
                }
                else if (first == "Sort")
                {
                    words.Sort((x, y) => y.CompareTo(x));
                }
                else if (first == "Replace")
                {
                    string word1 = arguments[1];
                    string word2 = arguments[2];

                    if (words.Contains(word2))
                    {
                        int index = words.IndexOf(word2);
                        words[index] = word1;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", words));
        }
    }
}
