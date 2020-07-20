using System;
using Gkdr.Producer.services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using XRoadLib.Extensions.AspNetCore;

namespace Gkdr.Producer
{
    public class Startup
    {
        private IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => 
                options.UseMySql(Configuration.GetConnectionString("Default"), builder =>
                {
                    builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null!);
                }));

            services.AddControllers()
            .AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });

            services.AddSwaggerGen();
            
            services.AddScoped<IGkdrService, GkdrService>();
            services.AddScoped<IGkdrSoapService, GkdrSoapService>();
            services.AddScoped<TundukServiceManager>();
            services.Configure<KestrelServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });
            
            services.AddXRoadLib();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
            app.UseRouting();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
            
            app.UseXRoadLib(routes =>
            {
                routes.MapWsdl<TundukServiceManager>("");
                routes.MapWebService<TundukServiceManager>("");
            });
        }
    }
}
