using System;
using System.Collections.Generic;
using System.Linq;

namespace legendaryFarming
{
    class legendaryFarming
    {
        static void Main(string[] args)
        {
            string[] keyMaterial = new string[] { "shards", "fragments", "motes" };

            string itemObtained = string.Empty;

            Dictionary<string, long> keyMaterials = new Dictionary<string, long>();
            Dictionary<string, long> junk = new Dictionary<string, long>();
            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;
            bool obtained = false;
            while (!obtained)
            {
                string[] arguments = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 0; i < arguments.Length; i+=2)
                {
                    long quantity = long.Parse(arguments[i]);
                    string material = arguments[i + 1].ToLower();

                    if (keyMaterial.Contains(material))
                    {
                        keyMaterials[material] += quantity;
                        if (keyMaterials.Any(z => z.Value >= 250))
                        {
                            if (material == "shards")
                            {
                                itemObtained = "Shadowmourne";
                            }
                            else if (material == "fragments")
                            {
                                itemObtained = "Valanyr";
                            }
                            else if (material == "motes")
                            {
                                itemObtained = "Dragonwrath";
                            }
                            keyMaterials[material] -= 250;
                            obtained = true;
                            break;
                        }

                        
                        
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk[material] = 0;

                        }

                        junk[material] += quantity;
                    }
                }
            }

            Console.WriteLine($"{itemObtained} obtained!");

            keyMaterials = keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in keyMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            junk = junk.OrderBy(kvp => kvp.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in junk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
