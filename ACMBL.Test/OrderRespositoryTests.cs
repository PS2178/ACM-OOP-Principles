using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ACMBL.Test
{
    public class OrderRespositoryTests
    {
        [Fact]
        public void RetrieveOrderDisplayTest()
        {
            // Arrange
            var orderReposiotory = new OrderRepository();
            var expected = new OrderDisplay()
            {
                FirstName = "Bilbo",
                LastName = "Baggins",
                OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7,0,0)),
                ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                },
                OrderDisplayItemList = new List<OrderDisplayItem>()
                {
                    new OrderDisplayItem()
                    {
                        OrderQuntity = 2,
                        ProductName = "Sunflowers",
                        PurchasePrice = 15.96M
                    },
                    new OrderDisplayItem()
                    {
                        OrderQuntity = 1,
                        ProductName = "Rake",
                        PurchasePrice = 6M
                    }
                }
            };

            // Act
            var actual = orderReposiotory.RetrieveOrderDisplay(10);

            // Assert
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.OrderDate, actual.OrderDate);

            Assert.Equal(expected.ShippingAddress.AddressType, actual.ShippingAddress.AddressType);
            Assert.Equal(expected.ShippingAddress.StreetLine1, actual.ShippingAddress.StreetLine1);
            Assert.Equal(expected.ShippingAddress.City, actual.ShippingAddress.City);
            Assert.Equal(expected.ShippingAddress.State, actual.ShippingAddress.State);
            Assert.Equal(expected.ShippingAddress.Country, actual.ShippingAddress.Country);
            Assert.Equal(expected.ShippingAddress.PostalCode, actual.ShippingAddress.PostalCode);

            for (int i = 0; i < 1; i++)
            {
                Assert.Equal(expected.OrderDisplayItemList[i].OrderQuntity, actual.OrderDisplayItemList[i].OrderQuntity);
                Assert.Equal(expected.OrderDisplayItemList[i].ProductName, actual.OrderDisplayItemList[i].ProductName);
                Assert.Equal(expected.OrderDisplayItemList[i].PurchasePrice, actual.OrderDisplayItemList[i].PurchasePrice);
            }
        }
    }
}
