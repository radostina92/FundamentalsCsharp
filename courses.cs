using System;
using System.Collections.Generic;
using System.Linq;

namespace courses
{
    class courses
    {
        static void Main(string[] args)
        {
           
            Dictionary<string, List<string>> names = new Dictionary<string, List<string>>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split(" : ");
                string courseName = arguments[0];
                string name = arguments[1];

                if (!names.ContainsKey(courseName))
                {
                    
                    names[courseName] = new List<string>();
                    names[courseName].Add(name);
                }
                else
                {
                    
                    names[courseName].Add(name);
                }

                

            }


            foreach (var item in names.OrderByDescending((kvp => kvp.Value.Count)))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                foreach (var kvp in item.Value.OrderBy(kvp => kvp))
                {
                    Console.WriteLine($"-- {kvp}");
                }
              
            }
        }
    }
}
