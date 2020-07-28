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
    public class EscolaRepository : Repository<Escola>, IEscolaRepository
    {
        private const string TABLE_NAME = "RT_Escola";

        public EscolaRepository(IConfiguration configuration,
                IApplicationLogger applicationLogger) :
            base(configuration, applicationLogger)
        {
        }

        public async Task SaveNewAsync(Escola escola)
        {
            var query = new StringBuilder($"INSERT INTO {TABLE_NAME} ");
            query.AppendLine(" ( ");
            query.AppendLine("  [RT_Escola_ID], ");
            query.AppendLine("  [Nome], ");
            query.AppendLine("  [Endereco] ");
            query.AppendLine(" ) ");
            query.AppendLine(" VALUES (@EscolaID, @Nome, @Endereco) ");

            await AddAsync(escola, query.ToString());
        }

        public async Task<IEnumerable<Escola>> GetAllAsync()
        {
            StringBuilder query = new StringBuilder("SELECT ");
            query.AppendLine("RT_Escola_ID as EscolaID,");
            query.AppendLine("Nome,");
            query.AppendLine("Endereco ");
            query.AppendLine($"FROM {TABLE_NAME}");

            return await FindAllAsync(query.ToString());
        }
    }
}
