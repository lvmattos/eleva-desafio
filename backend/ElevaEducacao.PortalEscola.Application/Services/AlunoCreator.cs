using ElevaEducacao.PortalEscola.Application.Util;
using ElevaEducacao.PortalEscola.Domain.DTO;
using ElevaEducacao.PortalEscola.Domain.Entities;
using ElevaEducacao.PortalEscola.Domain.Repositories;
using ElevaEducacao.PortalEscola.Domain.Services;
using System;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalEscola.Application.Services
{
    public class AlunoCreator : IAlunoCreator
    {
        private IAlunoRepository AlunoRepository { get; }
        private IAlunoTurmaRepository AlunoTurmaRepository { get; }

        public AlunoCreator(IAlunoRepository alunoRepository,
            IAlunoTurmaRepository alunoTurmaRepository)
        {
            Guardian.AgainstNull(alunoRepository);
            Guardian.AgainstNull(alunoTurmaRepository);

            AlunoRepository = alunoRepository;
            AlunoTurmaRepository = alunoTurmaRepository;
        }

        public async Task<Guid> AddAsync(AlunoDTO alunoDTO)
        {
            var aluno = new Aluno
            {
                AlunoID = Guid.NewGuid(),
                Nome = alunoDTO.Nome
            };
            await AlunoRepository.SaveNewAsync(aluno);

            await AlunoTurmaRepository.SaveNewAsync(new AlunoTurma
            {
                AlunoID = aluno.AlunoID,
                TurmaID = alunoDTO.TurmaID
            });

            return aluno.AlunoID;
        }
    }
}
