using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_2.Middleware
{
    public class Checking
    {
        private readonly RequestDelegate _next;
        public Checking(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, IConfiguration config)
        {
            var controllerActionDescritpor = httpContext
                                            .GetEndpoint()
                                            .Metadata
                                            .GetMetadata<ControllerActionDescriptor>();

            var controllerName = controllerActionDescritpor.ControllerName;
            var actionName = controllerActionDescritpor.ActionName;
            Endpoint endpoint = httpContext.Features.Get<IEndpointFeature>()?.Endpoint;

            if (endpoint != null)
            {
                var info = config.GetSection("Information").GetChildren().FirstOrDefault(x => x.Key == actionName);

                if (info != null && bool.Parse(info.Value))
                {
                    httpContext.SetEndpoint(new Endpoint((context) =>
                    {
                        context.Response.StatusCode = StatusCodes.Status404NotFound;
                        context.Response.WriteAsync(string.Join("\n", "Booking isn't available!"));
                        return Task.CompletedTask;
                    },
                    EndpointMetadataCollection.Empty, "Resource Not Founde"));
                }
            }
            await _next(httpContext);
        }
    }
}
