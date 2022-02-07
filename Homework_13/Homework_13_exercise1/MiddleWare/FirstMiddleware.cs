using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_13_exercise1.MiddleWare
{
    public class FirstMiddleware
    {
        private readonly RequestDelegate _next;
        public FirstMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext httpContext, IConfiguration config)
        {
            if (httpContext.Request.Path.Value.Contains("/commschool"))
            {
                var info = config.GetSection("Information");
                var report = info.GetChildren().Select(x => $"{x.Key}: {x.Value}");
                await httpContext.Response.WriteAsync(string.Join("\n", report));
            }
            else
            {
                await _next(httpContext);
            }
        }
    }
}
