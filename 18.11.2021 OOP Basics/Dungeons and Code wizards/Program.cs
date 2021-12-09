using System;

namespace Dungeons_and_Code_wizards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var faction = new Faction();

            var bag = new Bag(100);
            var ch = new Warrior("Kaloyan", faction);
            Item hp = new HealthPotion();

            ch.Bag.AddItem(hp);

            Console.WriteLine(ch.Health);
            ch.Health -= 20;

            Console.WriteLine(ch.Health);
            var item = ch.Bag.GetItem("Health Potion");
            ch.UseItem(item);

            Console.WriteLine(ch.Health);
        }
    }
}
