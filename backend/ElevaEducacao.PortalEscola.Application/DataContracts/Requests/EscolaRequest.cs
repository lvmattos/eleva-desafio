using System;

namespace ElevaEducacao.PortalEscola.Application.DataContracts.Requests
{
    public class EscolaRequest
    {
        public Guid EscolaID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
    }
}
