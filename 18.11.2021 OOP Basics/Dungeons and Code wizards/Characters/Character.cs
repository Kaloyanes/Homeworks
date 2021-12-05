using System;

namespace Dungeons_and_Code_wizards
{
    public abstract class Character : IAttackable, IHealable
    {
        public string Name { get; set; }
        public float BaseHealth { get; set; }
        public virtual float Health { get; set; }
        public float BaseArmor { get; set; }
        public virtual float Armor { get; set; }
        public float AbilityPoints { get; set; }
        public Bag Bag { get; set; }
        public bool IsAlive { get; set; } = true;
        public float RestHealMultiplier = 0.2f;
        public Faction Faction;

        /*public Character(string name, float health, float armor, float abilityPoints, Bag bag, Faction faction)
        {
            Name = name;
            BaseHealth = health;
            BaseArmor = armor;
            AbilityPoints = abilityPoints;
            Bag = bag;
            Faction = faction;
        }*/

        public void TakeDamage(float hitPoints)
        {
            if (!IsAlive)
                throw new InvalidOperationException("Must be alive to perform this action!");

            Health -= hitPoints;

            if (Health <= 0)
                IsAlive = false;
        }

        public void Rest()
        {
            if (!IsAlive)
                throw new InvalidOperationException("Must be alive to perform this action!");

            Health += Health * RestHealMultiplier;
        }

        // public void UseItem(Item Item)
        // {
        //     if (!IsAlive)
        //         throw new InvalidOperationException("Must be alive to perform this action!");
        //
        //     Item.AffectCharacter(this);
        // }

        public void UseItemOn(Item Item, Character character)
        {
            if (!IsAlive && !character.IsAlive)
                throw new InvalidOperationException("Must be alive to perform this action!");

            Item.AffectCharacter(character);
        }

        void GiveCharacterItem(Item item, Character character)
        {
            if (!IsAlive && !character.IsAlive)
                throw new InvalidOperationException("Must be alive to perform this action!");

            var itemToGive = Bag.GetItem(item._name);
            character.Bag.AddItem(itemToGive);
        }

        void RecieveItem(Item item)
        {
            if (!IsAlive)
                throw new InvalidOperationException("Must be alive to perform this action!");


            Bag.AddItem(item);
        }
    }
}