using ElevaEducacao.PortalEscola.Domain.Entities.Base;
using System;

namespace ElevaEducacao.PortalEscola.Domain.Entities
{
    public class Escola : Entity
    {
        public Guid EscolaID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
    }
}
