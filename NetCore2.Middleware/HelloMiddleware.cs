using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace NetCore2.Middleware
{
    public class HelloMiddleware
    {
        private readonly RequestDelegate next;

        public HelloMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync("Hello World (in class) \n");
            await next(context);
        }
    }
}
