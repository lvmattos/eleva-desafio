using System;

namespace ElevaEducacao.PortalEscola.Domain.DTO
{
    public class AlunoDTO
    {
        public Guid AlunoID { get; set; }
        public string Nome { get; set; }
        public Guid TurmaID { get; set; }
        public string NomeTurma { get; set; }
    }
}
