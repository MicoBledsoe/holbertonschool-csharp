using NUnit.Framework;
using System.Collections.Generic;
using InventoryLibrary;

namespace InventoryManagement.Tests
{
    [TestFixture]
    public class Tests
    {
        private JSONStorage storage;

        [SetUp]
        public void Setup()
        {
            storage = new JSONStorage();
        }

        [Test]
        public void BaseClass_IdIsUnique()
        {
            BaseClass a = new BaseClass();
            BaseClass b = new BaseClass();

            Assert.AreNotEqual(a.id, b.id);
        }

        [Test]
        public void BaseClass_DateCreatedAndDateUpdated()
        {
            BaseClass b = new BaseClass();

            Assert.AreNotEqual(b.date_created, b.date_updated);
            Assert.IsNotNull(b.date_created);
            Assert.IsNotNull(b.date_updated);
        }

        [Test]
        public void Item_NameAndDescriptionAndTags()
        {
            Item item = new Item("Item Name");

            Assert.AreEqual(item.name, "Item Name");
            Assert.IsNotNull(item.name);
            Assert.IsNull(item.description);
            Assert.IsNull(item.tags);
        }

        [Test]
        public void Item_DescriptionAndTags()
        {
            Item item = new Item("Item Thing", "Item Description");

            Assert.AreEqual(item.description, "Item Description");
            Assert.IsNotNull(item.description);
            Assert.IsNull(item.tags);
        }

        [Test]
        public void Item_Price()
        {
            Item item = new Item("Item Thing", "Item Description", 5.00f);

            Assert.AreEqual(item.price, 5.00);
        }

        [Test]
        public void User_Name()
        {
            User user = new User("User Name");

            Assert.AreEqual(user.name, "User Name");
        }

        [Test]
        public void Inventory_UserIdAndItemId()
        {
            Inventory inventory = new Inventory("User ID", "Item ID", 1);

            Assert.AreEqual(inventory.user_id, "User ID");
            Assert.AreNotEqual(inventory.user_id, inventory.item_id);
        }

        [Test]
        public void Inventory_ItemId()
        {
            Inventory inventory = new Inventory("User ID", "Item ID", 1);

            Assert.AreEqual(inventory.item_id, "Item ID");
            Assert.AreNotEqual(inventory.item_id, inventory.user_id);
        }

        [Test]
        public void Inventory_QuantityPositive()
        {
            Inventory inventory = new Inventory("User ID", "Item ID", 1);

            Assert.AreEqual(inventory.quantity, 1);
            Assert.AreNotEqual(inventory.quantity, 0);
        }

        [Test]
        public void Inventory_QuantityZero()
        {
            Inventory inventory = new Inventory("User ID", "Item ID", 0);

            Assert.AreEqual(inventory.quantity, 1);
            Assert.AreNotEqual(inventory.quantity, 0);
        }

        [Test]
        public void Inventory_QuantityNegative()
        {
            Inventory inventory = new Inventory("User ID", "Item ID", -1);

            Assert.AreEqual(inventory.quantity, 1);
            Assert.AreNotEqual(inventory.quantity, -1);
        }

        [Test]
        public void JSONStorage_ObjectsIsEmpty()
        {
            Dictionary<string, object> example = new Dictionary<string, object>();

            Assert.AreEqual(storage.objects.Count, example.Count);
        }
    }
}
