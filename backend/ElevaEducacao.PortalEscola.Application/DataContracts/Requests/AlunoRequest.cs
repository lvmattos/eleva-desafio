using System;

namespace ElevaEducacao.PortalEscola.Application.DataContracts.Requests
{
    public class AlunoRequest
    {
        public Guid AlunoID { get; set; }
        public string Nome { get; set; }
        public Guid TurmaID { get; set; }
    }
}
