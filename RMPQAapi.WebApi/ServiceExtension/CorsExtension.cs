using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RMPQAapi.WebApi.ServiceExtension
{
    public static class CorsExtension
    {
        public static void AddCorsSettings(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .WithExposedHeaders("Token-Expired", "InvalidRefreshToken", "InvalidCredentials")
                    .WithOrigins("http://localhost:4200")
                    .AllowCredentials()
                    .Build());
            });
    }
}
