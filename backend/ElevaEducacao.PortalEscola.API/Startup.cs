using AutoMapper;
using ElevaEducacao.PortalEscola.API.CustomMiddleware;
using ElevaEducacao.PortalEscola.Application.Infrastructure.AutoMapper;
using ElevaEducacao.PortalEscola.Common;
using ElevaEducacao.PortalEscola.CrossCutting.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Serilog;
using Serilog.Sinks.MSSqlServer;
using Serilog.Sinks.MSSqlServer.Sinks.MSSqlServer.Options;
using System;

namespace ElevaEducacao.PortalEscola.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            ConfigureLog();

            services.AddControllers();

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Eleva Educação - Portal Escola API"
                });
            });
            
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            AutoMapperConfiguration.RegisterMappings();

            services.AddResponseCompression(options =>
            {
                options.Providers.Add<BrotliCompressionProvider>();
            });

            NativeDependencyInjector.RegisterServices(services);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseMiddleware<CustomExceptionHandlerMiddleware>();

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGet("/api", async context =>
                {
                    await context.Response.WriteAsync("Portal Escola API");
                });
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.OAuthAppName("Portal Escola API v1");
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "Portal Escola API v1");
                c.RoutePrefix = string.Empty;
            });
            app.UseResponseCompression();
        }

        private void ConfigureLog()
        {
            Log.Logger =
                new LoggerConfiguration()
                    .MinimumLevel.Debug()
                    .WriteTo
                    .MSSqlServer(
                        connectionString: Configuration[Constants.LogConnectionString],
                        sinkOptions: new SinkOptions
                        {
                            TableName = "PortalEscola_Logs",
                            SchemaName = "dbo"
                        },
                        columnOptions: new ColumnOptions()
                    ).CreateLogger();
        }
    }
}
