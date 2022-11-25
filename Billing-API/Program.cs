using BillingLibrary;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
#region SwaggerGen
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#endregion
#region CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyAllowedOrigins",
    policy =>
    {
        policy.AllowAnyOrigin() // note the port is included 
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});
#endregion
#region Services
builder.Services.AddScoped<BillingContracts, BillingServices>();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
#endregion
var app = builder.Build();
app.UseCors("MyAllowedOrigins");
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
ClientsEndpoints(app);
#endregion
app.Run();
public partial class Program { }