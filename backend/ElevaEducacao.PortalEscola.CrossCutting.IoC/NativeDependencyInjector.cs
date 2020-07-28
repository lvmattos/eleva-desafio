using ElevaEducacao.PortalEscola.Application.Infrastructure;
using ElevaEducacao.PortalEscola.Application.Services;
using ElevaEducacao.PortalEscola.DataAccess.Repositories;
using ElevaEducacao.PortalEscola.Domain.Repositories;
using ElevaEducacao.PortalEscola.Domain.Services;
using ElevaEducacao.PortalEscola.Logger;
using Microsoft.Extensions.DependencyInjection;

namespace ElevaEducacao.PortalEscola.CrossCutting.IoC
{
    public class NativeDependencyInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IApplicationLogger, ApplicationLogger>();

            //Services
            services.AddScoped<IEscolaRetriever, EscolaRetriever>();
            services.AddScoped<IEscolaCreator, EscolaCreator>();
            services.AddScoped<IAlunoRetriever, AlunoRetriever>();
            services.AddScoped<IAlunoCreator, AlunoCreator>();
            services.AddScoped<ITurmaRetriever, TurmaRetriever>();
            services.AddScoped<ITurmaCreator, TurmaCreator>();

            //Repositories
            services.AddScoped<IEscolaRepository, EscolaRepository>();
            services.AddScoped<IAlunoRepository, AlunoRepository>();
            services.AddScoped<ITurmaRepository, TurmaRepository>();
            services.AddScoped<IAlunoTurmaRepository, AlunoTurmaRepository>();            
        }
    }
}
