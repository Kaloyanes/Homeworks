using System;

namespace Dungeons_and_Code_wizards
{
    public class ArmorRepairKit : Item
    {
        public string _name { get; set; }
        public int _weight { get; set; }

        public ArmorRepairKit()
        {
            _name = "Armor Repair Kit";
            _weight = 10;
        }

        public void AffectCharacter(Character character)
        {
            if (!character.IsAlive)
                throw new InvalidOperationException("Must be alive to perform this action!");

            character.Armor = character.BaseArmor;
        }
    }
}