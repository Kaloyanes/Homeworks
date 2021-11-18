using System;

namespace Dungeons_and_Code_wizards
{
    public class HealthPotion
    {
        public string _name { get; set; }
        public int _weight { get; set; }

        public HealthPotion()
        {
            _name = "Health Potion";
            _weight = 5;
        }

        public void AffectCharacter(Character character)
        {
            if (!character.IsAlive)
                throw new InvalidOperationException("Must be alive to perform this action!");


            character._health += 20f;
        }
    }
}