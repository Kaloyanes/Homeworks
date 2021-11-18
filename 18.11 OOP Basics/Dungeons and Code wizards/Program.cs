using System;

namespace Dungeons_and_Code_wizards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ch = new Character(true);
            var hp = new HealthPotion();
            var bag = new Bag(100);
            bag.AddItem(hp);
        }
    }
}
