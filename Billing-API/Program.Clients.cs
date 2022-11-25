using BillingLibrary;
partial class Program
{
    private static void ClientsEndpoints(WebApplication app)
    {
        app.MapGet("/Client", (int ClientId, BillingContracts _BillingServices) =>
        {
            var client = _BillingServices.getClient(ClientId);
            if (client != null)
            {
                return Results.Ok(client);
            }
            else
            {
                return Results.Problem($"No client associated with id {ClientId}");
            }

        }).WithName("GetClientData");
    }
}
