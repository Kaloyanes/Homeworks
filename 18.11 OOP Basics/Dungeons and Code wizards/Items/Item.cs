using System;

namespace Dungeons_and_Code_wizards
{
    public interface Item
    {
        public string _name { get; set; }
        public int _weight { get; set; }

        public void AffectCharacter(Character character)
        {
            if (!character.IsAlive)
                throw new InvalidOperationException("Must be alive to perform this action!");
        }
    }
}