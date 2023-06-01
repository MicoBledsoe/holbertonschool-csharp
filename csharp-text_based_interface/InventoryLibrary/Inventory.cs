using System;

namespace InventoryLibrary
{
    public class Inventory : BaseClass
    {
        // Required properties
        public string UserId { get; set; }
        public string ItemId { get; set; }
        public int Quantity { get; set; }

        public Inventory(string userId, string itemId, int quantity = 1)
        {
            this.UserId = userId;
            this.ItemId = itemId;
            this.Quantity = Math.Max(quantity, 0);
            this.Id = Guid.NewGuid().ToString();
            this.DateCreated = DateTime.UtcNow;
            this.DateUpdated = DateTime.UtcNow;
        }
    }
}