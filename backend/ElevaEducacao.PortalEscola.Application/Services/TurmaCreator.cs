using ElevaEducacao.PortalEscola.Application.Util;
using ElevaEducacao.PortalEscola.Domain.Entities;
using ElevaEducacao.PortalEscola.Domain.Repositories;
using ElevaEducacao.PortalEscola.Domain.Services;
using System;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalEscola.Application.Services
{
    public class TurmaCreator : ITurmaCreator
    {
        private ITurmaRepository TurmaRepository { get; }

        public TurmaCreator(ITurmaRepository turmaRepository)
        {
            Guardian.AgainstNull(turmaRepository);

            TurmaRepository = turmaRepository;
        }

        public async Task<Guid> AddAsync(Turma turma)
        {
            turma.TurmaID = Guid.NewGuid();
            await TurmaRepository.SaveNewAsync(turma);

            return turma.TurmaID;
        }
    }
}
