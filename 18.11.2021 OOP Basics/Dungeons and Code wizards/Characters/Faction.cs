using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Dungeons_and_Code_wizards
{
    public class Faction
    {
        public string Name { get; set; }
        public List<Character> members = new List<Character>();

        public void AddMember(Character character)
        {
            members.Add(character);
            Console.WriteLine($"");
        }
    }
}