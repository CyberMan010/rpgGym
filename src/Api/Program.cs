using Application.Services;
using Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<HealthService>();
builder.Services.AddSingleton<InMemoryDatabase>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.MapGet("/health", (HealthService svc) => Results.Ok(svc.GetStatus()));

app.Run();
