using BillingLibrary;
using BillingLibrary.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingApiTest
{
    public class UnitTest
    {
        [Fact]
        public void getClient()
        {
            // Arrange
            var mockService = new Mock<BillingContracts>();
            mockService.Setup(p => p.getClient(1)).Returns(new ClientModel { Id = 1, Name = "Test" });
            var result = mockService.Object.getClient(1);
            // Assert
            Assert.Equal("Test", result.Name);
        }
    }
}
