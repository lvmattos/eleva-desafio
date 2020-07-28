using ElevaEducacao.PortalEscola.Application.DataContracts;
using ElevaEducacao.PortalEscola.Application.Infrastructure;
using ElevaEducacao.PortalEscola.Application.Util;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalEscola.API.CustomMiddleware
{
    public class CustomExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private IApplicationLogger ApplicationLogger { get; }
        private IWebHostEnvironment WebHostEnvironment { get; }

        public CustomExceptionHandlerMiddleware(RequestDelegate next,
            IApplicationLogger applicationLogger, IWebHostEnvironment webHostEnvironment)
        {
            _next = next;
            Guardian.AgainstNull(applicationLogger);
            Guardian.AgainstNull(webHostEnvironment);

            ApplicationLogger = applicationLogger;
            WebHostEnvironment = webHostEnvironment;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception ex)
            {
                ApplicationLogger.LogError(ex, ex.Message);
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var response = context.Response;
            response.ContentType = "application/json";
            response.StatusCode = (int)HttpStatusCode.InternalServerError;
            var message = "Unexpected error ocurred. Contact the system's adminstrator";

            await response.WriteAsync(JsonConvert.SerializeObject(
                new DefaultContractResponse(
                    response.StatusCode,
                    WebHostEnvironment.IsDevelopment() ? exception.Message : message)
                ));
        }
    }
}
