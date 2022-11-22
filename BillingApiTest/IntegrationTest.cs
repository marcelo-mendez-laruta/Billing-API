using BillingLibrary.Models;
using IntegrationTests.Helpers;
using Newtonsoft.Json;

namespace BillingApiTest
{
    [Collection("Sequential")]
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
    }

}
