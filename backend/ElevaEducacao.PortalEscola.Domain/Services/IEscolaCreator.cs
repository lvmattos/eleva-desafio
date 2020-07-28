using ElevaEducacao.PortalEscola.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalEscola.Domain.Services
{
    public interface IEscolaCreator
    {
        Task<Guid> AddAsync(Escola escola);
    }
}
