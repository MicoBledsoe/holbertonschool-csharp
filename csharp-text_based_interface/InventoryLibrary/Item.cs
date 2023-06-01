using System.Collections.Generic;
using System;

namespace InventoryLibrary
{
    public class Item : BaseClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }

        public Item(string id, string name, string description, float price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            DateCreated = DateTime.Now;
            DateUpdated = DateTime.Now;
        }

        public override string ToString()
        {
            return $"ID: {Id}\nName: {Name}\nDescription: {Description}\nPrice: {Price}\nCreated: {DateCreated}\nUpdated: {DateUpdated}";
        }
    }
}
