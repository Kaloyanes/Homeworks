using System;

namespace Dungeons_and_Code_wizards
{
    public class PoisonPotion : Item
    {
        public string _name { get; set; }
        public int _weight { get; set; }

        public PoisonPotion()
        {
            _name = "Poison Potion";
            _weight = 5;
        }

        public void AffectCharacter(Character character)
        {
            if (!character.IsAlive)
                throw new InvalidOperationException("Must be alive to perform this action!");


            character.Health -= 20f;

            if (character.Health <= 0)
            {
                character.IsAlive = false;
            }
        }
    }
}