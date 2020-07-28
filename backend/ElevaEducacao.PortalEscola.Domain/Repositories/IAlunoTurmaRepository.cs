using ElevaEducacao.PortalEscola.Domain.Entities;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalEscola.Domain.Repositories
{
    public interface IAlunoTurmaRepository
    {
        Task SaveNewAsync(AlunoTurma alunoTurma);
    }
}
