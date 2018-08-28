using Microsoft.AspNetCore.Builder;

namespace NetCore2.Configuration
{
    public static class MiddlewareExtension
    {
        public static IApplicationBuilder UseHelloWorld(this IApplicationBuilder app)
        {
            return app.UseMiddleware<HelloWorldMiddleware>();
        }
    }
}
