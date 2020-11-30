using System;
using System.Collections.Generic;

namespace minerTask
{
    class minerTask
    {
        static void Main(string[] args)
        {
            string product = string.Empty;
            Dictionary<string, long> counts = new Dictionary<string, long>();


            while ((product = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!counts.ContainsKey(product))
                {
                    counts[product] = 0;
                }

                counts[product] += quantity;
            }

            foreach (var kvp in counts)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
