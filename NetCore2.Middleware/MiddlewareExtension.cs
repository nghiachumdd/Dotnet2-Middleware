using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;

namespace NetCore2.Middleware
{
    public static class MiddlewareExtension
    {
        public static void RunHelloWorld(this IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World (Run) \n");
            });
        }

        public static IApplicationBuilder UseInClass(this IApplicationBuilder app)
        {
            return app.UseMiddleware<HelloMiddleware>();
        }

        public static IApplicationBuilder UseHelloWorld(this IApplicationBuilder app)
        {
            return app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello World (Use) \n");
                await next();
            });
        }

        public static IApplicationBuilder UseGreetingInstanceType(this IApplicationBuilder app)
        {
            return app.UseMiddleware<GreetingMiddleware>(new GreetingOptions
            {
                GreetAt = "Morning",
                GreetTo = "Nghia"
            });
        }

        public static IApplicationBuilder UserGreetingFunctionType(this IApplicationBuilder app, Action<GreetingOptions> configurationOptions)
        {
            GreetingOptions options = new GreetingOptions();
            configurationOptions(options);
            return app.UseMiddleware<GreetingMiddleware>(options);
        }
    }
}
