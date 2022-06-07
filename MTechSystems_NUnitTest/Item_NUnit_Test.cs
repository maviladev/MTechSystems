using MTechSystems.Entities;
using NUnit.Framework;

namespace MTechSystems_NUnitTest
{
    [TestFixture]
    public class Item_NUnit_Test
    {
        private Item _item;

        [SetUp]
        public void Setup()
        {
            _item = new Item();
        }

        [Test]
        public void ItemNameProperty_Empty_ReturnsNull() 
        {
            Assert.IsNull(_item.Name);
        }

        [Test]
        [TestCase("Name")]
        public void ItemNameProperty_NotEmpty_ReturnsNotNull(string name)
        {
            _item.Name = name;
            Assert.IsNotNull(_item.Name);
        }

        [Test]
        public void ItemAmountProperty_Empty_ReturnsZero()
        {
            Assert.AreEqual(0,_item.Amount);
        }

        [Test]
        [TestCase(1)]
        public void ItemAmountProperty_NotEmpty_ReturnsCorrectAmount(int amount)
        {
            _item.Amount = amount;
            Assert.AreEqual(1,_item.Amount);
        }

        [Test]
        public void ItemPriceProperty_NotSet_ReturnsZero()
        {
            Assert.AreEqual(0, _item.Price, 0.1);
        }

        [Test]
        [TestCase(3.4)]
        public void ItemNameProperty_NotEmpty_ReturnsNotNull(double price)
        {
            _item.Price = price;
            Assert.AreEqual(3.4, _item.Price, 0.1);
        }
    }
}