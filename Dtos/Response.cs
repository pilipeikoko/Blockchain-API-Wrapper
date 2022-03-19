using Newtonsoft.Json;

namespace BlockchainAnalysis.Dtos
{
    internal abstract class Response
    {
        [JsonProperty("status")]
        public string Status { get; private set; }

        [JsonProperty("message")]
        public string Message { get; private set; }
    }
}