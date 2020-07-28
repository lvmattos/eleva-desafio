using ElevaEducacao.PortalEscola.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalEscola.Domain.Repositories
{
    public interface ITurmaRepository
    {
        Task SaveNewAsync(Turma turma);
        Task<IEnumerable<Turma>> GetAllAsync();
    }
}
