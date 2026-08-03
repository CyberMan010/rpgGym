using API.Extensions;


var builder = WebApplication.CreateBuilder(args);


// Register services
builder.Services
    .AddApplicationServices(builder.Configuration);



var app = builder.Build();


// Register middlewares
app.UseApplicationMiddlewares();


app.Run();