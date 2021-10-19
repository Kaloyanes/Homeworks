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
            /*
                FireBird -> FireMane
                Phoenix -> FireVoid
                FireVoid -> FireMane
                FireSnow -> FireMane
                Phoenix -> FireBird
                FireMane -> FireBird
                FireMane -> FireVoid
                Phoenix -> FireSnow
                FireMane -> FireSnow
                FireMane -> FireMane
                Phoenix -> FireMane
                Phoenix -> FireVoid
                Blaze it!

             */

            Dictionary<string, List<string>> squads = new Dictionary<string, List<string>>();
            Dictionary<string, int> squadmates = new Dictionary<string, int>();
            while (true)
            {
                string[] input = Console.ReadLine().Trim().Split(" -> ").ToArray();
            
                if (input[0] == "Blaze it!") break;
            
                string creature = input[0];
                string squadmate = input[1];

                if (creature == squadmate)
                    continue;

                else if (squads.ContainsKey(creature) && squads[creature].Contains(squadmate) &&
                         squads.ContainsKey(squadmate) && squads[squadmate].Contains(creature) && squadmates[creature] != 0)
                    squadmates[creature] -= 1;

                else if (squads.ContainsKey(creature) && !squads[creature].Contains(creature))
                    squadmates[creature]++;

                else if (squads.ContainsKey(creature))
                {
                    squads[creature].Add(squadmate);
                    squadmates[creature]++;
                }

                else
                {
                    squads.Add(creature, new List<string>());
                    squadmates.Add(creature, 0);
                }
            }

            Console.WriteLine();
            foreach (var squadmate in squadmates.OrderByDescending(n => n.Value))
            {
                Console.WriteLine($"{squadmate.Key}: {squadmate.Value}");
            }
        }
    }
}
