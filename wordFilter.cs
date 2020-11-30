using System;
using System.Linq;

namespace wordFilter
{
    class wordFilter
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .Where(w => w.Length % 2 == 0)
                .ToArray();

            Console.WriteLine(string.Join("\n",words));

        }
    }
}
