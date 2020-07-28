using AutoMapper;
using ElevaEducacao.PortalEscola.Application.DataContracts.Requests;
using ElevaEducacao.PortalEscola.Application.DataContracts.Responses;
using ElevaEducacao.PortalEscola.Domain.Entities;

namespace ElevaEducacao.PortalEscola.Application.Infrastructure.AutoMapper.Profiles
{
    public class TurmaProfile : Profile
    {
        public TurmaProfile()
        {
            CreateMap<TurmaRequest, Turma>();
            CreateMap<Turma, TurmaResponse>();
        }
    }
}
