using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> junk = new Dictionary<string, int>();
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);
            bool isCollected = false;

            while (true)
            {
                string[] input = Console.ReadLine().ToLower().Split();

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1];

                    switch (material)
                    {
                        case "shards":
                            keyMaterials["shards"] += quantity;
                            break;
                        case "fragments":
                            keyMaterials["fragments"] += quantity;
                            break;
                        case "motes":
                            keyMaterials["motes"] += quantity;
                            break;

                        default:
                            if (junk.ContainsKey(material))
                            {
                                junk[material] += quantity;
                            }
                            else
                            {
                                junk.Add(material, quantity);
                            }
                            break;
                    }

                    if (keyMaterials["shards"] >= 250)
                    {
                        keyMaterials["shards"] -= 250;
                        Console.WriteLine("Shadowmourne obtained!");
                        isCollected = true;
                        break;
                    }
                    else if (keyMaterials["fragments"] >= 250)
                    {
                        keyMaterials["fragments"] -= 250;
                        Console.WriteLine("Valanyr obtained!");
                        isCollected = true;
                        break;
                    }
                    else if (keyMaterials["motes"] >= 250)
                    {
                        keyMaterials["motes"] -= 250;
                        Console.WriteLine("Dragonwrath obtained!");
                        isCollected = true;
                        break;
                    }
                }
                if (isCollected)
                {
                    break;
                }
            }
            var sortedMaterials = keyMaterials
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(p => p.Key, p => p.Value);

            var sortedJunk = junk
                .OrderBy(kvp => kvp.Key)
                .ToDictionary(p => p.Key, p => p.Value);

            foreach (var kvp in sortedMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in sortedJunk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
