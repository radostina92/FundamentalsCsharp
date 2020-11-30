using System;
using System.Collections.Generic;
using System.Linq;

namespace studentAcademy
{
    class studentAcademy
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();



            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!grades.ContainsKey(name))
                {
                    grades.Add(name, new List<double>());
                }
                grades[name].Add(grade);
            }

            grades = grades.OrderByDescending(x => x.Value.Average())
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var item in grades)
            {
                if (item.Value.Average() >= 4.50)
                {

                    Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
                }
            }
        }
    }
}
