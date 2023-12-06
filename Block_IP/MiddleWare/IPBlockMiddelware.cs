using Block_IP.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Net;
using System.Threading.Tasks;

namespace Block_IP.MiddleWare
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class IPBlockMiddelware
    {
        private readonly RequestDelegate _next;
        private readonly IIPBlockingService _blockingService;
        public IPBlockMiddelware(RequestDelegate next, IIPBlockingService blockingService)
        {
            _next = next;
            _blockingService = blockingService;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            var remoteIp = httpContext.Connection.RemoteIpAddress;
            var isBlocked = _blockingService.IsBlocked(remoteIp!);
            if (isBlocked)
            {
                httpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                return;
            }

            await _next.Invoke(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class IPBlockMiddelwareExtensions
    {
        public static IApplicationBuilder UseIPBlockMiddelware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<IPBlockMiddelware>();
        }
    }
}
