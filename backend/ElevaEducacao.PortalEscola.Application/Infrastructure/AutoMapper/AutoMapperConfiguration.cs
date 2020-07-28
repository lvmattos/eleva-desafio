using AutoMapper;
using ElevaEducacao.PortalEscola.Application.Infrastructure.AutoMapper.Profiles;

namespace ElevaEducacao.PortalEscola.Application.Infrastructure.AutoMapper
{
	public class AutoMapperConfiguration
    {
		public static MapperConfiguration RegisterMappings()
		{
			return new MapperConfiguration(cfg =>
			{
				cfg.AddProfile(new EscolaProfile());
				cfg.AddProfile(new TurmaProfile());
				cfg.AddProfile(new AlunoProfile());
			});
		}
	}
}
