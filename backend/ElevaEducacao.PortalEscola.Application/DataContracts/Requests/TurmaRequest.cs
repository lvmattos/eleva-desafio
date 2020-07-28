using System;

namespace ElevaEducacao.PortalEscola.Application.DataContracts.Requests
{
    public class TurmaRequest
    {
        public Guid EscolaID { get; set; }
        public string Nome { get; set; }
    }
}
