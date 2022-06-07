using MTechSystems.Abstractions;
using MTechSystems.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTechSystems
{
    [TestFixture]
    public class ShoppingCart_NUnit_Test
    {
        private ShoppingCart _cart;

        [SetUp]
        public void Setup()
        {
            _cart = new ShoppingCart();
        }

        [Test]
        public void PurchaseDateProperty_NotEmpty_ReturnsNotNull()
        {
            Assert.IsNotNull(_cart.PurchaseDate);
        }

        [Test]
        public void ItemListProperty_Empty_ReturnsZero()
        {
            Assert.AreEqual(0, _cart.ItemList.Count);
        }

        [Test]
        [TestCase]
        public void ItemListProperty_NotEmpty_ReturnsCount()
        {
            var item = new Item() { Name = "Name", Amount = 4, Price = 17 };
            _cart.AddItem(item);

            
            Assert.That(_cart.ItemList.Count, Is.EqualTo(1));
        }

        [Test]
        public void PurchaseTotalProperty_NotSet_ReturnsZero()
        {
            Assert.AreEqual(0, _cart.PurchaseTotal, 0.1);
        }

        [Test]
        [TestCase]
        public void PurchaseTotalProperty_NotEmptyItems_ReturnsCorrectTotal()
        {
            var item = new Item() { Name = "Name", Amount = 4, Price = 17 };
            _cart.AddItem(item);
            Assert.AreEqual(68, _cart.PurchaseTotal, 0.1);
        }
    }
}
