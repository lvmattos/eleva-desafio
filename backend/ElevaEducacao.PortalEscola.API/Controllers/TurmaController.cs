using AutoMapper;
using ElevaEducacao.PortalEscola.Application.DataContracts.Requests;
using ElevaEducacao.PortalEscola.Application.DataContracts.Responses;
using ElevaEducacao.PortalEscola.Application.Util;
using ElevaEducacao.PortalEscola.Domain.Entities;
using ElevaEducacao.PortalEscola.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalTurma.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        public IMapper Mapper { get; }
        public ITurmaRetriever TurmaRetriever { get; }
        public ITurmaCreator TurmaCreator { get; }

        public TurmaController(IMapper mapper,
            ITurmaRetriever escolaRetriever,
            ITurmaCreator escolaCreator)
        {
            Guardian.AgainstNull(mapper);
            Guardian.AgainstNull(escolaRetriever);
            Guardian.AgainstNull(escolaCreator);

            Mapper = mapper;
            TurmaRetriever = escolaRetriever;
            TurmaCreator = escolaCreator;
        }

        [HttpPost]
        public async Task<IActionResult> Post(TurmaRequest request)
        {
            var escola = Mapper.Map<Turma>(request);
            return Ok(await TurmaCreator.AddAsync(escola));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var escola = await TurmaRetriever.GetAllAsync();
            return Ok(Mapper.Map<IEnumerable<TurmaResponse>>(escola));
        }
    }
}