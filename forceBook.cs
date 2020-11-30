using System;
using System.Collections.Generic;
using System.Linq;

namespace forceBook
{
    class forceBook
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> book = new Dictionary<string, List<string>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] user = input
                    .Split(new string[] { "|", "->" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (input.Contains("|"))
                {
                    string side = user[0];
                    string userName = user[1];

                    AddUserToBook(book, side, userName);
                }
                else if (input.Contains("->"))
                {
                    string userName = user[0];
                    string side = user[1];

                    MoveUserToSide(book, userName, side);
                }
            }

            Dictionary<string, List<string>> orderedBook = book.Where(b => b.Value.Count > 0).
               OrderByDescending(kvp => kvp.Value.Count).
               ThenBy(kvp => kvp.Key).
               ToDictionary(a => a.Key, b => b.Value);

            foreach (var side in orderedBook)
            {
                string sides = side.Key;
                List<string> currentSideUsers = side.Value.
                    OrderBy(x => x).ToList();

                Console.WriteLine($"Side: {sides}, Members: {currentSideUsers.Count}");
                foreach (var kvp in currentSideUsers)
                {
                    Console.WriteLine($"! {kvp}");
                }
            }
        }

        private static void MoveUserToSide(Dictionary<string, List<string>> book, string userName, string side)
        {
            foreach (var kvp in book)
            {
                if (kvp.Value.Contains(userName))
                {
                    kvp.Value.Remove(userName);
                }

            
            }
            if (!book.ContainsKey(side))
            {
                book[side] = new List<string>();

            }
            book[side].Add(userName);


            Console.WriteLine($"{userName} joins the {side} side!");
        }

        private static void AddUserToBook(Dictionary<string, List<string>> book, string side, string userName)
        {
            if (!book.ContainsKey(side))
            {
                book[side] = new List<string>();
            }

            if (!book.Values.Any(l => l.Contains(userName)))
            {
                book[side].Add(userName);
            }
        }
    }
}
