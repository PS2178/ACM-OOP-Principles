using System;
using Xunit;

namespace ACMBL.Test
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            // Arrange
            var customer = new Customer()
            {
                FirstName = "Ray",
                LastName = "Cooper"
            };
            string expected = "Cooper, Ray";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            var customer = new Customer()
            {
                FirstName = "",
                LastName = "Cooper"
            };
            string expected = "Cooper";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            var customer = new Customer() { FirstName = "Ray" };
            string expected = "Ray";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer() { FirstName = "Bilbo" };
            Customer.InstanceCount += 1;
            var c2 = new Customer() { FirstName = "Frodo" };
            Customer.InstanceCount += 1;
            var c3 = new Customer() { FirstName = "Rosie" };
            Customer.InstanceCount += 1;

            // Act
            // Assert
            Assert.Equal(3, Customer.InstanceCount);
        }

        [Fact]
        public void ValidateValid()
        {
            // Arrange
            var customer = new Customer() { LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me" };
            var expected = true;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateMissingLastName()
        {
            // Arrange
            var customer = new Customer() { EmailAddress = "fbaggins@hobbiton.me" };
            var expected = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
