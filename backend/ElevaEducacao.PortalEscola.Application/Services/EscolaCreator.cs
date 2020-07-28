using ElevaEducacao.PortalEscola.Application.Util;
using ElevaEducacao.PortalEscola.Domain.Entities;
using ElevaEducacao.PortalEscola.Domain.Repositories;
using ElevaEducacao.PortalEscola.Domain.Services;
using System;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalEscola.Application.Services
{
    public class EscolaCreator : IEscolaCreator
    {
        private IEscolaRepository EscolaRepository { get; }

        public EscolaCreator(IEscolaRepository escolaRepository)
        {
            Guardian.AgainstNull(escolaRepository);

            EscolaRepository = escolaRepository;
        }

        public async Task<Guid> AddAsync(Escola escola)
        {
            escola.EscolaID = Guid.NewGuid();
            await EscolaRepository.SaveNewAsync(escola);

            return escola.EscolaID;
        }
    }
}
