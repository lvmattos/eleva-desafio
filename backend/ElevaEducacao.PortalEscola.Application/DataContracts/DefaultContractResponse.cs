namespace ElevaEducacao.PortalEscola.Application.DataContracts
{
    public class DefaultContractResponse
    {
        public int StatusCode { get; }
        public string Message { get; }
        public object Data { get; }

        public DefaultContractResponse(int status, string message)
        {
            StatusCode = status;
            Message = message;
        }
    }
}
