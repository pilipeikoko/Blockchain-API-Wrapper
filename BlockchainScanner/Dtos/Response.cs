using Newtonsoft.Json;

namespace BlockchainScanner.Dtos
{
    internal abstract class Response
    {
        [JsonProperty("status")]
        public string Status { get; private set; }

        [JsonProperty("message")]
        public string Message { get; private set; }
    }
}