using ElevaEducacao.PortalEscola.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalEscola.Domain.Services
{
    public interface ITurmaRetriever
    {
        Task<IEnumerable<Turma>> GetAllAsync();
    }
}
