using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetreiveOrderDisplayTest()
        {
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),
            };

            var actual = orderRepository.Retreive(10);

            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
