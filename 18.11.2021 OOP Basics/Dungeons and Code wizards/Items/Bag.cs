using System;
using System.Collections.Generic;

namespace Dungeons_and_Code_wizards
{
    public class Bag
    {
        private int _capacity;
        private int _load;
        public List<Item> items = new List<Item>();

        public Bag(int capacity)
        {
            _capacity = capacity;
        }

        public void AddItem(Item item)
        {
            Console.WriteLine($"Adding {item._name} to bag");
            _load += item._weight;

            if (_load >= _capacity)
                throw new InvalidOperationException("Bag is full");

            items.Add(item);
        }

        public Item GetItem(string name)
        {
            if (items.Count == 0)
                throw new InvalidOperationException("Bag is empty!");

            foreach (var item in items)
            {
                if (item._name == name)
                {
                    items.Remove(item);
                    _load -= item._weight;
                    return item;
                }
            }

            throw new ArgumentException($"No item with name: {name} in bag!");
        }
    }
}