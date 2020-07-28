using AutoMapper;
using ElevaEducacao.PortalEscola.Application.DataContracts.Requests;
using ElevaEducacao.PortalEscola.Application.DataContracts.Responses;
using ElevaEducacao.PortalEscola.Application.Util;
using ElevaEducacao.PortalEscola.Domain.Entities;
using ElevaEducacao.PortalEscola.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalEscola.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscolaController : ControllerBase
    {
        public IMapper Mapper { get; }
        public IEscolaRetriever EscolaRetriever { get; }
        public IEscolaCreator EscolaCreator { get; }

        public EscolaController(IMapper mapper,
            IEscolaRetriever escolaRetriever,
            IEscolaCreator escolaCreator)
        {
            Guardian.AgainstNull(mapper);
            Guardian.AgainstNull(escolaRetriever);
            Guardian.AgainstNull(escolaCreator);

            Mapper = mapper;
            EscolaRetriever = escolaRetriever;
            EscolaCreator = escolaCreator;
        }

        [HttpPost]
        public async Task<IActionResult> Post(EscolaRequest request)
        {
            var escola = Mapper.Map<Escola>(request);
            return Ok(await EscolaCreator.AddAsync(escola));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var escola = await EscolaRetriever.GetAllAsync();
            return Ok(Mapper.Map<IEnumerable<EscolaResponse>>(escola));
        }
    }
}