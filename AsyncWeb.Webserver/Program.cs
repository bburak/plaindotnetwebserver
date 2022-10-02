using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;


Host.CreateDefaultBuilder(args)
    // HTTP request comes in it should run this method.
    // Whenever HTTP request comes in we answer with Hello World.
    .ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder.Configure(app =>
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello World");
            });
        });
    })
    .Build().Run();   