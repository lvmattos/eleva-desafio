using ElevaEducacao.PortalEscola.Domain.Entities.Base;
using System;

namespace ElevaEducacao.PortalEscola.Domain.Entities
{
    public class Turma : Entity
    {
        public Guid TurmaID { get; set; }
        public Guid EscolaID { get; set; }
        public string Nome { get; set; }
    }
}
