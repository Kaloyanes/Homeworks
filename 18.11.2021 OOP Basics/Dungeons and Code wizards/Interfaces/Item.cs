using System;

namespace Dungeons_and_Code_wizards
{
    public interface Item
    {
        public string _name { get; }
        public int _weight { get; }

        public void AffectCharacter(Character character);
    }
}