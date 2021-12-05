using System;

namespace Dungeons_and_Code_wizards
{
    public class HealthPotion : Item
    {
        public string _name { get; }= "Health Potion";
        public int _weight { get; } = 5;

        public void AffectCharacter(Character character)
        {
            if (!character.IsAlive)
                throw new InvalidOperationException("Must be alive to perform this action!");

            // TODO: Оправи това да може да heal-ва

            character.Health += 20;
        }
    }
}