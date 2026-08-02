using Application.ServiceRegistration;
using Application.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Auto-register all services marked with ServiceRegistrationAttribute
builder.Services.AddAutoRegisteredServices(
    typeof(Program).Assembly,
    Assembly.Load("Application"),
    Assembly.Load("Infrastructure")
);

//[ServiceRegistration]  // Defaults to Singleton
//public class MyService { }

//[ServiceRegistration(ServiceLifetime.Scoped)]
//public class MyScopedService { }

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.MapGet("/health", (HealthService svc) => Results.Ok(svc.GetStatus()));

app.Run();
