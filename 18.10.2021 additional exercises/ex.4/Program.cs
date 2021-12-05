using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ex._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> squads = new Dictionary<string, List<string>>();
            Dictionary<string, int> squadMates = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().Trim().Split(" -> ").ToArray();
            
                if (input[0] == "Blaze it!") break;
            
                string creature = input[0];
                string squadmate = input[1];

                if (creature == squadmate)
                    continue;

                if (squads.ContainsKey(creature))
                {
                    squads[creature].Add(squadmate);
                    squadMates[creature]++;
                }

                if (squads.ContainsKey(creature) && squads.ContainsKey(squadmate) && squads[creature].Contains(squadmate) && squads[squadmate].Contains(creature))
                {
                    if (squadMates[creature] == 0)
                        squadMates[squadmate]--;
                    
                    else if (squadMates[squadmate] == 0)
                        squadMates[creature]--;

                    else
                    {
                        squadMates[creature]--;
                        squadMates[squadmate]--;
                    }
                }

                else if(!squads.ContainsKey(creature))
                {
                    squads.Add(creature, new List<string>(){squadmate});
                    squadMates.Add(creature, 0);
                }
            }

            Console.WriteLine();
            foreach (var squadmate in squadMates.OrderByDescending(n => n.Value))
            {
                Console.WriteLine($"{squadmate.Key}: {squadmate.Value}");
            }
        }
    }
}
