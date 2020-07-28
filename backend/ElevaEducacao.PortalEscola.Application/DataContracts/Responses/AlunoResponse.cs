using System;

namespace ElevaEducacao.PortalEscola.Application.DataContracts.Responses
{
    public class AlunoResponse
    {
        public Guid AlunoID { get; set; }
        public string Nome { get; set; }
        public Guid TurmaID { get; set; }
        public string NomeTurma { get; set; }
    }
}
