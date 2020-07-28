using AutoMapper;
using ElevaEducacao.PortalEscola.Application.DataContracts.Requests;
using ElevaEducacao.PortalEscola.Application.DataContracts.Responses;
using ElevaEducacao.PortalEscola.Application.Util;
using ElevaEducacao.PortalEscola.Domain.DTO;
using ElevaEducacao.PortalEscola.Domain.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalAluno.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AlunoController : ControllerBase
    {
        public IMapper Mapper { get; }
        public IAlunoRetriever AlunoRetriever { get; }
        public IAlunoCreator AlunoCreator { get; }

        public AlunoController(IMapper mapper,
            IAlunoRetriever escolaRetriever,
            IAlunoCreator escolaCreator)
        {
            Guardian.AgainstNull(mapper);
            Guardian.AgainstNull(escolaRetriever);
            Guardian.AgainstNull(escolaCreator);

            Mapper = mapper;
            AlunoRetriever = escolaRetriever;
            AlunoCreator = escolaCreator;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AlunoRequest request)
        {
            var escola = Mapper.Map<AlunoDTO>(request);
            return Ok(await AlunoCreator.AddAsync(escola));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var escola = await AlunoRetriever.GetAllAsync();
            return Ok(Mapper.Map<IEnumerable<AlunoResponse>>(escola));
        }
    }
}