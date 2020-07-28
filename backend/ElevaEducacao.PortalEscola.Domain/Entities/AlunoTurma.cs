using ElevaEducacao.PortalEscola.Domain.Entities.Base;
using System;

namespace ElevaEducacao.PortalEscola.Domain.Entities
{
    public class AlunoTurma : Entity
    {
        public Guid AlunoTurmaID { get; set; }
        public Guid AlunoID { get; set; }
        public Guid TurmaID { get; set; }
    }
}
