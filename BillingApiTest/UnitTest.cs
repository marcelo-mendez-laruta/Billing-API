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
            var mockService = new Mock<BillingContracts>();
            mockService.Setup(p => p.getClient(1)).Returns(new ClientModel { Id = 1, Name = "Test" });
            var result = mockService.Object.getClient(1);
            Assert.Equal("Test", result.Name);
        }
        [Fact]
        public void CreateNewBill()
        {
            var mockService = new Mock<BillingContracts>();
            BillModel newBill = new BillModel { ClientId = 1, Category = "Test", Amount = 100, CreatedOn = DateTime.Now, State = "Pending", Period = 202211 };
            mockService.Setup(p => p.Create(newBill)).Returns(new List<BillModel> { newBill });
            var result = mockService.Object.Create(newBill);
            Assert.Equal("Test", result[0].Category);
        }
        [Fact]
        public void GetPendingBills()
        {
            var mockService = new Mock<BillingContracts>();
            BillModel newBill = new BillModel { ClientId = 1, Category = "Test", Amount = 100, CreatedOn = DateTime.Now, State = "Pending", Period = 202211 };
            mockService.Setup(p => p.Pending(1)).Returns(new List<BillModel> { newBill });
            var result = mockService.Object.Pending(1);
            Assert.Equal("Test", result[0].Category);
        }
        [Fact]
        public void PayBill()
        {
            var mockService = new Mock<BillingContracts>();
            BillModel newBill = new BillModel {Category = "Test", Period = 202211 };
            mockService.Setup(p => p.Pay(newBill)).Returns("Success");
            var result = mockService.Object.Pay(newBill);
            Assert.Equal("Success", result);
        }
        [Fact]
        public void PayBillById()
        {
            var mockService = new Mock<BillingContracts>();
            mockService.Setup(p => p.PayById(1)).Returns("Success");
            var result = mockService.Object.PayById(1);
            Assert.Equal("Success", result);
        }
        [Fact]
        public void SearchBill()
        {
            var mockService = new Mock<BillingContracts>();
            BillModel newBill = new BillModel { Category = "Test", Period = 202211 };
            mockService.Setup(p => p.Search("Test")).Returns(new List<BillModel> { newBill });
            var result = mockService.Object.Search("Test");
            Assert.Equal("Test", result[0].Category);
        }
        [Fact]
        public void GetPaymentHistory()
        {
            var mockService = new Mock<BillingContracts>();
            BillModel newBill = new BillModel { Category = "Test", Period = 202211 };
            mockService.Setup(p => p.PaymentHistory(1)).Returns(new List<BillModel> { newBill });
            var result = mockService.Object.PaymentHistory(1);
            Assert.Equal("Test", result[0].Category);
        }
    }
}
