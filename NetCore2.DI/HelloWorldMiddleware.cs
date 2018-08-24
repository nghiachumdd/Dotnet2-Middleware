using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace NetCore2.DI
{
    public class HelloWorldMiddleware
    {
        private readonly RequestDelegate next;

        public HelloWorldMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context, IGreetingService greetingService)
        {
            await context.Response.WriteAsync(greetingService.Greeting("Xin chao"));
            await next(context);
        }
    }
}