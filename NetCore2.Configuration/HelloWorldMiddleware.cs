using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace NetCore2.Configuration
{
    public class HelloWorldMiddleware
    {
        private readonly AppSettings settings;

        public HelloWorldMiddleware(RequestDelegate next, IOptions<AppSettings> options)
        {
            settings = options.Value;
        }
        public async Task Invoke(HttpContext context)
        {
            var jsonSetting = JsonConvert.SerializeObject(settings);
            await context.Response.WriteAsync(jsonSetting);
        }
    }
}
