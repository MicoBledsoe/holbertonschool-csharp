using Xunit;
using InventoryLibrary;

namespace InventoryManagement.Tests
{
    public class ItemTests
    {
        [Fact]
        public void Item_ToString_ReturnsExpectedString()
        {
            // Arrange
            var item = new Item
            {
                Name = "Item 1",
                Description = "This is item 1",
                Price = 9.99f,
                Tags = new List<string> { "tag1", "tag2" }
            };

            // Act
            string result = item.ToString();

            // Assert
            Assert.Equal("Name: Item 1, Description: This is item 1, Price: $9.99, Tags: tag1, tag2", result);
        }
    }
}