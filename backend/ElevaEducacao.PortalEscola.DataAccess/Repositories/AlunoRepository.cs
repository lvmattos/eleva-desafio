using ElevaEducacao.PortalEscola.Application.Infrastructure;
using ElevaEducacao.PortalEscola.DataAccess.Repositories.Base;
using ElevaEducacao.PortalEscola.Domain.DTO;
using ElevaEducacao.PortalEscola.Domain.Entities;
using ElevaEducacao.PortalEscola.Domain.Repositories;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalEscola.DataAccess.Repositories
{
    public class AlunoRepository : Repository<Aluno>, IAlunoRepository
    {
        private const string TABLE_NAME = "RT_Aluno";

        public AlunoRepository(IConfiguration configuration,
                IApplicationLogger applicationLogger) :
            base(configuration, applicationLogger)
        {
        }

        public async Task SaveNewAsync(Aluno aluno)
        {
            var query = new StringBuilder($"INSERT INTO {TABLE_NAME} ");
            query.AppendLine(" ( ");
            query.AppendLine("  [RT_Aluno_ID], ");
            query.AppendLine("  [Nome] ");
            query.AppendLine(" ) ");
            query.AppendLine(" VALUES (@AlunoID, @Nome) ");

            await AddAsync(aluno, query.ToString());
        }

        public async Task<IEnumerable<AlunoDTO>> GetAllAsync()
        {
            StringBuilder query = new StringBuilder("SELECT ");
            query.AppendLine("A.RT_Aluno_ID as AlunoID, ");
            query.AppendLine("A.Nome as Nome, ");
            query.AppendLine("T.RT_Turma_ID as TurmaID, ");
            query.AppendLine("T.Nome as NomeTurma ");
            query.AppendLine($"FROM {TABLE_NAME} A ");
            query.AppendLine("JOIN RE_AlunoTurma AT on A.RT_Aluno_ID = AT.RT_Aluno_ID ");
            query.AppendLine("JOIN RT_Turma T on T.RT_Turma_ID = AT.RT_Turma_ID ");

            return await QueryAllAsync<AlunoDTO>(query.ToString());
        }
    }
}
