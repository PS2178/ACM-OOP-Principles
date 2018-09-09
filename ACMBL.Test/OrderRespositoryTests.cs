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
                FirstName = "Frodo",
                LastName = "Baggins",
                OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7,0,0)),

            };
        }
    }
}
