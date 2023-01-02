var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.Run(async context =>
{
    await context.Response.WriteAsync("Welcome! I'm .NET 6 web server.");
});

app.Run();
