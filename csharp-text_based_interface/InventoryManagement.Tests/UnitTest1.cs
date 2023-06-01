using NUnit.Framework;
using InventoryLibrary;

namespace InventoryManagement.Tests
{
    [TestFixture]
    public class InventoryManagerTests
    {
        private BaseClass testCase;
        private Item testItem;
        private User testUser;

        [SetUp]
        public void Setup()
        {
            testCase = new BaseClass();
            testItem = new Item("testItem");
            testUser = new User("testUser");
        }

        [Test]
        public void PropertyTypeTests()
        {
            Assert.That(testCase.id, Is.TypeOf<string>());
            Assert.That(testCase.date_created, Is.TypeOf<System.DateTime>());
            Assert.That(testCase.date_updated, Is.TypeOf<System.DateTime>());

            Assert.That(testCase.id, Is.Not.Null);
            Assert.That(testCase.date_created, Is.Not.Null);
            Assert.That(testCase.date_updated, Is.Not.Null);
        }

        [Test]
        public void ItemTest()
        {
            Assert.That(testItem.name, Is.TypeOf<string>());
            Assert.That(testItem.description, Is.TypeOf<string>());
            Assert.That(testItem.price, Is.TypeOf<float>());
            Assert.That(testItem.tags, Is.TypeOf<string[]>());

            Assert.That(testItem.name, Is.Not.Null);
        }

        [TestCase(new string[] { "dogs" }, ExpectedResult = 1)]
        [TestCase(new string[] { "dogs", "cats" }, ExpectedResult = 2)]
        [TestCase(new string[] { "dogs", "cats", "dogs" }, ExpectedResult = 2)]
        [TestCase(new string[] { "dogs", "cats", "dogs", "cats" }, ExpectedResult = 2)]
        [TestCase(new string[] { }, ExpectedResult = 0)]
        public int TagCountTest(params string[] value)
        {
            var item = new Item("testItem", tags: value);
            return item.tags.Length;
        }

        [Test]
        public void UserTest()
        {
            Assert.That(testUser.name, Is.TypeOf<string>());
            Assert.That(testUser.name, Is.Not.Null);
        }

        [TestCase("testUser", ExpectedResult = "testUser")]
        [TestCase("testUser2", ExpectedResult = "testUser2")]
        [TestCase(null, ExpectedResult = "user")]
        public string UserNameTest(string value)
        {
            var user = new User(value);
            Assert.That(user.name, Is.Not.Null);
            return user.name;
        }

        [TestCase(1, ExpectedResult = 1)]
        [TestCase(2, ExpectedResult = 2)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(-1, ExpectedResult = 0)]
        public int InventoryCreationTests(int value)
        {
            var inventory = new Inventory(testUser, testItem, value);
            Assert.That(inventory.user_id, Is.Not.Null);
            Assert.That(inventory.item_id, Is.Not.Null);
            Assert.That(inventory.user_id, Is.EqualTo(testUser.id));
            Assert.That(inventory.item_id, Is.EqualTo(testItem.id));
            return inventory.quantity;
        }

        [TestCase(1, ExpectedResult = 1)]
        [TestCase(2, ExpectedResult = 2)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(-1, ExpectedResult = 0)]
        public int InventorySetQuantityTests(int value)
        {
            var inventory = new Inventory(testUser, testItem);
            inventory.quantity = value;
            return inventory.quantity;
        }
    }
}
