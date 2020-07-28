using ElevaEducacao.PortalEscola.Application.Util;
using ElevaEducacao.PortalEscola.Domain.DTO;
using ElevaEducacao.PortalEscola.Domain.Repositories;
using ElevaEducacao.PortalEscola.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalEscola.Application.Services
{
    public class AlunoRetriever : IAlunoRetriever
    {
        private IAlunoRepository AlunoRepository { get; }

        public AlunoRetriever(IAlunoRepository alunoRepository)
        {
            Guardian.AgainstNull(alunoRepository);

            AlunoRepository = alunoRepository;
        }

        public async Task<IEnumerable<AlunoDTO>> GetAllAsync()
        {
            return await AlunoRepository.GetAllAsync();
        }
    }
}
