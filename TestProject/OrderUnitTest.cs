using KProject;

namespace TestProject
{
    [TestClass]
    public class OrderUnitTest
    {
        private readonly Order order = new(new Person("Recipient", "122221"), new Person("Sender", "333333"))
        {
            Id = 1,
            UserId = 1,
            DepartureDate = DateTime.Now,
            Description = "Test",
            DepartureCity = "Kharkiv",
            DeliveryCity = "Êè¿â",
            Weight = 20,
            Payment = 2000,
            OrderType = OrderType.CREATED
        };

        [TestMethod]
        public void OrderCreateTest()
        {
            // Assert
            Assert.IsNotNull(order);
        }

        [TestMethod]
        public void IsNotNullOrderRecipientTest()
        {
            // Assert
            Assert.IsNotNull(order.Recipient);
        }

        [TestMethod]
        public void OrderCalcShippingCostTest()
        {
            // Act
            order.ShippingCost = order.CalcShippingCost();
            float shippingCost = order.ShippingCost;

            // Assert
            Assert.IsTrue(shippingCost > 0);
        }

        [TestMethod]
        public void ChangeOrderTypeTest()
        {
            // Arrange
            order.ChangeOrderType(OrderType.DELIVERED);

            // Act
            OrderType orderType = order.OrderType;
            DateTime? dateTime = order.DeliveryDate;

            // Assert
            Assert.AreEqual(orderType, OrderType.DELIVERED);
            Assert.IsNotNull(dateTime);
        }
    }
}