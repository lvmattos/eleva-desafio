using ElevaEducacao.PortalEscola.Application.Infrastructure;
using Serilog;
using System;

namespace ElevaEducacao.PortalEscola.Logger
{
    public class ApplicationLogger : IApplicationLogger
    {
        public void LogInformation(string message, params object[] propertyValues)
        {
            Log.Logger.Information(message, propertyValues);
        }

        public void LogWarning(string message, params object[] propertyValues)
        {
            Log.Logger.Warning(message, propertyValues);
        }

        public void LogError(Exception ex, string message, params object[] propertyValues)
        {
            Log.Logger.Error(ex, message, propertyValues);
        }
    }
}
