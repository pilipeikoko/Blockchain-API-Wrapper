using Newtonsoft.Json;

namespace BlockchainAnalysis.Dtos.Responses
{
    internal class ErrorResponse : Response
    {
        [JsonProperty("result")] 
        public string ErrorMessage { get; set; }
    }
}
