using System;
using System.Collections.Generic;
using System.Linq;

namespace companyUsers
{
    class companyUsers
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyNames = new Dictionary<string, List<string>>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split(" -> ",StringSplitOptions.RemoveEmptyEntries);

                string name = arguments[0];
                string label = arguments[1];

                if (!companyNames.ContainsKey(name))
                {
                    companyNames[name] = new List<string>();
                    companyNames[name].Add(label);

                }

                if (!companyNames[name].Contains(label))
                {
                    companyNames[name].Add(label);
                }
            }

            foreach (var item in companyNames.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var kvp in item.Value)
                {
                    
                    Console.WriteLine($"-- {kvp}");
                }
            }
        }
    }
}
