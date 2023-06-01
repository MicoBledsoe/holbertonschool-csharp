using System;

namespace InventoryLibrary
{
    public class User : BaseClass
    {
        // Required property
        public string Name { get; set; }

        public User(string name)
        {
            this.Name = name;
            this.Id = Guid.NewGuid().ToString();
            this.DateCreated = DateTime.UtcNow;
            this.DateUpdated = DateTime.UtcNow;
        }
    }
}