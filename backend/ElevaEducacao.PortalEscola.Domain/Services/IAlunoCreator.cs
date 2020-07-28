using ElevaEducacao.PortalEscola.Domain.DTO;
using System;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalEscola.Domain.Services
{
    public interface IAlunoCreator
    {
        Task<Guid> AddAsync(AlunoDTO escola);
    }
}
