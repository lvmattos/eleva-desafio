using System;

namespace ElevaEducacao.PortalEscola.Application.DataContracts.Responses
{
    public class TurmaResponse
    {
        public Guid TurmaID { get; set; }
        public Guid EscolaID { get; set; }
        public string Nome { get; set; }
    }
}
