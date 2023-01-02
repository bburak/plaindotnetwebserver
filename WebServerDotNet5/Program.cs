using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

// HTTP request comes in it should run this method.
// Whenever HTTP request comes in we answer with Hello World.
Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder.Configure(app =>
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Welcome! I'm .NET 5 web server.");
            });
        });
    })
    .Build().Run();   