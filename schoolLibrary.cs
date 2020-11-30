using System;
using System.Collections.Generic;
using System.Linq;

namespace schoolLibrary
{
    class schoolLibrary
    {
        static void Main(string[] args)
        {
            List<string> library = Console.ReadLine().Split("&").ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Done")
            {
                string[] arguments = command.Split(" | ");
                string name = arguments[0];
                string book = arguments[1];
                if (name == "Add Book")
                {
                    if (!library.Contains(book))
                    {
                        library.Insert(0, book);
                    }
                }
                else if (name == "Take Book")
                {
                    if (library.Contains(book))
                    {
                        library.Remove(book);
                    }
                }
                else if (name == "Swap Books")
                {
                    string book2 = arguments[2];
                    if (library.Contains(book) && library.Contains(book2))
                    {
                        int index = library.IndexOf(book);
                        int index2 = library.IndexOf(book2);
                        library[index] = book2;
                        library[index2] = book;
                    }
                }
                else if (name == "Insert Book")
                {
                    if (!library.Contains(book))
                    {
                        library.Add(book);
                    }
                }
                else if (name == "Check Book")
                {
                    int index = int.Parse(book);
                    if (index >= 0 && index < library.Count)
                    {
                        Console.WriteLine(library[index]);
                    }
                }

                
            }

            Console.WriteLine(string.Join(", ", library));
        }
    }
}
