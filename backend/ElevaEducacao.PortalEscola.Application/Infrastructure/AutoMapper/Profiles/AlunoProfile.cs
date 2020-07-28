using AutoMapper;
using ElevaEducacao.PortalEscola.Application.DataContracts.Requests;
using ElevaEducacao.PortalEscola.Application.DataContracts.Responses;
using ElevaEducacao.PortalEscola.Domain.DTO;

namespace ElevaEducacao.PortalEscola.Application.Infrastructure.AutoMapper.Profiles
{
    public class AlunoProfile : Profile
    {
        public AlunoProfile()
        {
            CreateMap<AlunoRequest, AlunoDTO>();
            CreateMap<AlunoDTO, AlunoResponse>();
        }
    }
}
