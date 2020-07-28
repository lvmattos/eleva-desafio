using ElevaEducacao.PortalEscola.Domain.DTO;
using ElevaEducacao.PortalEscola.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalEscola.Domain.Repositories
{
    public interface IAlunoRepository
    {
        Task SaveNewAsync(Aluno aluno);
        Task<IEnumerable<AlunoDTO>> GetAllAsync();
    }
}
