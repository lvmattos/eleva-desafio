using ElevaEducacao.PortalEscola.Application.Util;
using ElevaEducacao.PortalEscola.Domain.Entities;
using ElevaEducacao.PortalEscola.Domain.Repositories;
using ElevaEducacao.PortalEscola.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalEscola.Application.Services
{
    public class TurmaRetriever : ITurmaRetriever
    {
        private ITurmaRepository TurmaRepository { get; }

        public TurmaRetriever(ITurmaRepository turmaRepository)
        {
            Guardian.AgainstNull(turmaRepository);

            TurmaRepository = turmaRepository;
        }

        public async Task<IEnumerable<Turma>> GetAllAsync()
        {
            return await TurmaRepository.GetAllAsync();
        }
    }
}
