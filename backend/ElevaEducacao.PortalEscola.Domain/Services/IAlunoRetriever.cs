using ElevaEducacao.PortalEscola.Domain.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalEscola.Domain.Services
{
    public interface IAlunoRetriever
    {
        Task<IEnumerable<AlunoDTO>> GetAllAsync();
    }
}
