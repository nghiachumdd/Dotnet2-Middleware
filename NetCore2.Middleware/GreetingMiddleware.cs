using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace NetCore2.Middleware
{
    public class GreetingMiddleware
    {
        private readonly RequestDelegate next;
        private readonly GreetingOptions greetOption;

        public GreetingMiddleware(RequestDelegate next, GreetingOptions greetOption)
        {
            this.next = next;
            this.greetOption = greetOption;
        }

        public async Task Invoke(HttpContext context)
        {
            string message = $"Good {greetOption.GreetAt}, {greetOption.GreetTo} (in class - option parameter) \n";
            await context.Response.WriteAsync(message);
            await next(context);
        }
    }    
}
