using ElevaEducacao.PortalEscola.Domain.Entities.Base;
using System;

namespace ElevaEducacao.PortalEscola.Domain.Entities
{
    public class Aluno : Entity
    {
        public Guid AlunoID { get; set; }
        public string Nome { get; set; }
    }
}
