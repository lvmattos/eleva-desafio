using ElevaEducacao.PortalEscola.Application.Infrastructure;
using ElevaEducacao.PortalEscola.DataAccess.Repositories.Base;
using ElevaEducacao.PortalEscola.Domain.Entities;
using ElevaEducacao.PortalEscola.Domain.Repositories;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalEscola.DataAccess.Repositories
{
    public class AlunoTurmaRepository : Repository<AlunoTurma>, IAlunoTurmaRepository
    {
        private const string TABLE_NAME = "RE_AlunoTurma";

        public AlunoTurmaRepository(IConfiguration configuration,
                IApplicationLogger applicationLogger) :
            base(configuration, applicationLogger)
        {
        }

        public async Task SaveNewAsync(AlunoTurma alunoTurma)
        {
            var query = new StringBuilder($"INSERT INTO {TABLE_NAME} ");
            query.AppendLine(" ( ");
            query.AppendLine("  RT_Aluno_ID, ");
            query.AppendLine("  RT_Turma_ID ");
            query.AppendLine(" ) ");
            query.AppendLine(" VALUES (@AlunoID, @TurmaID) ");

            await AddAsync(alunoTurma, query.ToString());
        }
    }
}
