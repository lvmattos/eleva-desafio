using ElevaEducacao.PortalEscola.Application.Util;
using ElevaEducacao.PortalEscola.Domain.Entities;
using ElevaEducacao.PortalEscola.Domain.Repositories;
using ElevaEducacao.PortalEscola.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalEscola.Application.Services
{
    public class EscolaRetriever : IEscolaRetriever
    {
        private IEscolaRepository EscolaRepository { get; }

        public EscolaRetriever(IEscolaRepository escolaRepository)
        {
            Guardian.AgainstNull(escolaRepository);

            EscolaRepository = escolaRepository;
        }

        public async Task<IEnumerable<Escola>> GetAllAsync()
        {
            return await EscolaRepository.GetAllAsync();
        }
    }
}
