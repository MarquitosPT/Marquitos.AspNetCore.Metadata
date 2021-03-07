using Microsoft.AspNetCore.Http;
using System.Net.Mime;
#if NETCOREAPP3_1_OR_GREATER
using System.Text.Json;
#else
using Newtonsoft.Json;
#endif
using System.Threading.Tasks;

namespace Marquitos.AspNetCore.Metadata
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MetadataMiddleware
    {
        private readonly RequestDelegate _next;

        public MetadataMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            if (httpContext.Request.Path.Value.Equals("/" + Metadata.Path))
            {
#if NETCOREAPP3_1_OR_GREATER
                httpContext.Response.Clear();
#endif
                httpContext.Response.StatusCode = 200;
                httpContext.Response.ContentType = MediaTypeNames.Application.Json;

#if NETCOREAPP3_1_OR_GREATER
                await httpContext.Response.WriteAsync(JsonSerializer.Serialize(Metadata.Information));
#else
                await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(Metadata.Information));
#endif

                return;
            }

            await _next(httpContext);
        }
    }
}
