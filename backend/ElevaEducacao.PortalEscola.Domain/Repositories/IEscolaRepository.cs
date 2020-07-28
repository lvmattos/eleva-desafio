using ElevaEducacao.PortalEscola.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalEscola.Domain.Repositories
{
    public interface IEscolaRepository
    {
        Task SaveNewAsync(Escola escola);
        Task<IEnumerable<Escola>> GetAllAsync();
    }
}
