using Marquitos.AspNetCore.Metadata.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;
using System.Reflection;

namespace Marquitos.AspNetCore.Metadata
{
    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MetadataMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestMeta(this IApplicationBuilder builder, string path = "api/_meta")
        {
#if NETCOREAPP3_1_OR_GREATER
            var env = builder.ApplicationServices.GetService<IWebHostEnvironment>();
#else
            var env = builder.ApplicationServices.GetService<IHostingEnvironment>();
#endif

            var fileVersionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);

            Metadata.Information = new MetaInfo
            {
                Environment = env.EnvironmentName,
                Name = env.ApplicationName,
                StartedOn = DateTimeOffset.Now,
                Version = new VersionInfo
                {
                    Major = fileVersionInfo.FileMajorPart,
                    Minor = fileVersionInfo.FileMinorPart,
                    Patch = fileVersionInfo.FileBuildPart,
                    Revision = fileVersionInfo.FilePrivatePart,
                    ProductVersion = fileVersionInfo.ProductVersion
                }
            };
            Metadata.Path = path;

            return builder.UseMiddleware<MetadataMiddleware>();
        }
    }
}
