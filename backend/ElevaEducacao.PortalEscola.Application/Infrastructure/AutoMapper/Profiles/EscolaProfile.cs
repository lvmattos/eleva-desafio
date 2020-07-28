using AutoMapper;
using ElevaEducacao.PortalEscola.Application.DataContracts.Requests;
using ElevaEducacao.PortalEscola.Application.DataContracts.Responses;
using ElevaEducacao.PortalEscola.Domain.Entities;

namespace ElevaEducacao.PortalEscola.Application.Infrastructure.AutoMapper.Profiles
{
    public class EscolaProfile : Profile
    {
        public EscolaProfile()
        {
            CreateMap<Escola, EscolaResponse>();
            CreateMap<EscolaRequest, Escola>();
        }
    }
}
