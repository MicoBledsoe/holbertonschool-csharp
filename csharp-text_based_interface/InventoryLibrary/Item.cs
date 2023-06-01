using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    public class Item : BaseClass
    {
        // Required property
        public string Name { get; set; }

        // Optional properties
        public string Description { get; set; }
        public float Price { get; set; }
        public List<string> Tags { get; set; }

        public Item(string name)
        {
            this.Name = name;
            this.Id = Guid.NewGuid().ToString();
            this.DateCreated = DateTime.UtcNow;
            this.DateUpdated = DateTime.UtcNow;
        }
    }
}