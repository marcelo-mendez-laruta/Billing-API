using BillingLibrary.Models;
using BillingLibrary;

partial class Program
{
    private static void BillingEndpoints(WebApplication app)
    {
        
        app.MapGet("/billing/pending", (int ClientId, BillingContracts _BillingServices) =>
        {
            if (_BillingServices.getClient(ClientId) != null)
            {
                return Results.Ok(_BillingServices.Pending(ClientId));
            }
            else
            {
                return Results.Problem($"No client associated with id {ClientId}");
            }

        }).WithName("BillingPending");
        app.MapGet("/billing/search", (string Category, BillingContracts _BillingServices) =>
        {
            var response = _BillingServices.Search(Category);
            return response.Count > 0 ? Results.Ok(response) : Results.Problem("There are no invoices associated with that category");
        }).WithName("BillingSearch");
        app.MapPost("/billing/pay", (BillModel pay, BillingContracts _BillingServices) =>
        {
            string response = _BillingServices.Pay(pay);
            return response == "success" ? Results.Ok("Payment made successfully") : Results.Problem(response);
        }).WithName("BillingPay");
        app.MapPost("/billing/payById", (int Id, BillingContracts _BillingServices) =>
        {
            string response = _BillingServices.PayById(Id);
            return response == "success" ? Results.Ok("Payment made successfully") : Results.Problem(response);
        }).WithName("BillingPayById");
        app.MapPost("/billing/bills", (BillModel bill, BillingContracts _BillingServices) =>
        {
            string response = _BillingServices.Create(bill);
            return response == "success" ? Results.Ok("Bill created successfully") : Results.Problem(response);
        })
        .WithName("BillingBills");
        app.MapGet("/billing/history", (int ClientId, BillingContracts _BillingServices) =>
        {
            if (_BillingServices.getClient(ClientId) != null)
            {
                return Results.Ok(_BillingServices.PaymentHistory(ClientId));
            }
            else
            {
                return Results.Problem($"No client associated with id {ClientId}");
            }
        })
        .WithName("BillingHistory");
    }
}