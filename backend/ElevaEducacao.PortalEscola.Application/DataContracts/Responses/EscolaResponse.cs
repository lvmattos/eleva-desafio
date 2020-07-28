using System;

namespace ElevaEducacao.PortalEscola.Application.DataContracts.Responses
{
    public class EscolaResponse
    {
        public Guid EscolaID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
    }
}
