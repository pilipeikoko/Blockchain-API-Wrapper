using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class ErrorResponse : Response
    {
        [JsonProperty("result")] 
        public string ErrorMessage { get; set; }
    }
}
