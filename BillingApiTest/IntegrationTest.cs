using BillingLibrary.Models;
using IntegrationTests.Helpers;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace BillingApiTest
{
    public class BillEndpointsTest : IClassFixture<BillWebApplicationFactory<Program>>
    {
        private readonly BillWebApplicationFactory<Program> _factory;
        private readonly HttpClient _httpClient;

        public BillEndpointsTest(BillWebApplicationFactory<Program> factory)
        {
            _factory = factory;
            _httpClient = factory.CreateClient();
        }

        [Fact]
        public async Task GetWellcomeMessage()
        {
            var response = await _httpClient.GetAsync("/");
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Equal("Hello and welcome to the Billing API.", responseString);
        }
        [Fact]
        public async Task GetPendingBills()
        {
            int ClientId = 1;
            var response = await _httpClient.GetAsync($"/billing/pending?ClientId={ClientId}");
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            List<BillModel> bills = JsonConvert.DeserializeObject<List<BillModel>>(responseString);

            Assert.Equal(ClientId, bills[0].ClientId);
        }
        [Fact]
        public async Task GetPendingBillsWithProblem()
        {
            int ClientId = 20;
            var response = await _httpClient.GetAsync($"/billing/pending?ClientId={ClientId}");
            //var Status = (int)response.StatusCode;
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Equal(500, (int)response.StatusCode);
            Assert.Contains($"No client associated with id {ClientId}", responseString);
        }
        [Fact]
        public async Task SearchAllBills()
        {
            var response = await _httpClient.GetAsync("/billing/search?Category=ALL");
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            List<BillModel> bills = JsonConvert.DeserializeObject<List<BillModel>>(responseString);
            Assert.NotEmpty(bills);
        }
        [Fact]
        public async Task SearchWaterBills()
        {
            var response = await _httpClient.GetAsync("/billing/search?Category=WATER");
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            List<BillModel> bills = JsonConvert.DeserializeObject<List<BillModel>>(responseString);
            Assert.NotEmpty(bills);
        }
        [Fact]
        public async Task PayBills()
        {
            BillModel request = new BillModel
            {
                Period = 202001,
                Category = "WATER",
                ClientId = 4
            };
            var response = await _httpClient.PostAsJsonAsync("/billing/pay", request);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Equal("\"Payment made successfully\"", responseString);
        }
        [Fact]
        public async Task PayBillsById()
        {
            int BillId = 1;
            var response = await _httpClient.PostAsync($"/billing/payById?Id={BillId}", null);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Equal("\"Payment made successfully\"", responseString);

        }
        [Fact]
        public async Task CreateBill()
        {
            BillModel request = new BillModel
            {
                Period = 202001,
                Category = "WATER",
                Amount = 100,
                ClientId = 4
            };
            var response = await _httpClient.PostAsJsonAsync("/billing/bills", request);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Equal("\"Bill created successfully\"", responseString);
        }
        [Fact]
        public async Task ClientBillHistory()
        {
            int ClientId = 3;
            var response = await _httpClient.GetAsync($"/billing/history?ClientId={ClientId}");
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            List<BillModel> bills = JsonConvert.DeserializeObject<List<BillModel>>(responseString);
            Assert.NotEmpty(bills);
        }
    }

}
