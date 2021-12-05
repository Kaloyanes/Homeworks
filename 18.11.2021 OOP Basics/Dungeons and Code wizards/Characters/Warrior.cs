using System;

namespace Dungeons_and_Code_wizards
{
    public class Warrior : Character
    {
        public string Name { get; set; }
        public const float BaseHealth = 100;
        public override float Health { get; set; }
        public const float BaseArmor = 50;
        public override float Armor { get; set; }
        public const int AbilityPoints = 40;
        public bool IsAlive { get; set; } = true;
        public Bag Bag = new Bag(20);
        public Faction Faction;
        public string CharacterType;

        public Warrior(string name, Faction faction)
        {
            Name = name;
            Faction = faction;
            Health = BaseHealth;
            Armor = BaseArmor;
        }

        public void Attack(Character character)
        {
            if (!IsAlive && !character.IsAlive)
                throw new InvalidOperationException("Must be alive to perform this action!");

            if (character.Name == Name)
                throw new InvalidOperationException("Cannot attack self!");

            if (character.Faction.Name == Faction.Name)
                throw new ArgumentException("Friendly Fire! Both Characters are from {0} faction", Faction.Name);

            character.Health -= AbilityPoints;
        }

        public void UseItem(Item item)
        {
            if (!IsAlive)
                throw new InvalidOperationException("Must be alive to perform this action!");

            item.AffectCharacter(this);
        }
    }
}