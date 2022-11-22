using BillingLibrary;
var builder = WebApplication.CreateBuilder(args);
#region SwaggerGen
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#endregion
#region Services
builder.Services.AddScoped<BillingContracts, BillingServices>();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
#endregion
var app = builder.Build();
#region Swagger Visibility
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
#endregion

app.MapGet("/", () => "Hello and welcome to the Billing API.");
#region Endpoints
BillingEndpoints(app);
#endregion
app.Run();
public partial class Program { }