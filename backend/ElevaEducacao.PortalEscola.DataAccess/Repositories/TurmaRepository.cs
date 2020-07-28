using ElevaEducacao.PortalEscola.Application.Infrastructure;
using ElevaEducacao.PortalEscola.DataAccess.Repositories.Base;
using ElevaEducacao.PortalEscola.Domain.Entities;
using ElevaEducacao.PortalEscola.Domain.Repositories;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalEscola.DataAccess.Repositories
{
    public class TurmaRepository : Repository<Turma>, ITurmaRepository
    {
        private const string TABLE_NAME = "RT_Turma";

        public TurmaRepository(IConfiguration configuration,
                IApplicationLogger applicationLogger) :
            base(configuration, applicationLogger)
        {
        }

        public async Task SaveNewAsync(Turma turma)
        {
            var query = new StringBuilder($"INSERT INTO {TABLE_NAME} ");
            query.AppendLine(" ( ");
            query.AppendLine("  [RT_Turma_ID], ");
            query.AppendLine("  [RT_Escola_ID], ");
            query.AppendLine("  [Nome] ");
            query.AppendLine(" ) ");
            query.AppendLine(" VALUES (@TurmaID, @EscolaID, @Nome) ");

            await AddAsync(turma, query.ToString());
        }

        public async Task<IEnumerable<Turma>> GetAllAsync()
        {
            StringBuilder query = new StringBuilder("SELECT ");
            query.AppendLine("RT_Turma_ID as TurmaID,");
            query.AppendLine("RT_Escola_ID as EscolaID,");
            query.AppendLine("Nome ");
            query.AppendLine($"FROM {TABLE_NAME}");

            return await FindAllAsync(query.ToString());
        }
    }
}
