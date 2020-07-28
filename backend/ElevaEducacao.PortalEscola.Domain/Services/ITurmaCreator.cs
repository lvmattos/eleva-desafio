using ElevaEducacao.PortalEscola.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalEscola.Domain.Services
{
    public interface ITurmaCreator
    {
        Task<Guid> AddAsync(Turma escola);
    }
}
