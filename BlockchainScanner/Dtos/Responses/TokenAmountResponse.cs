using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class TokenAmountResponse : Response
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }
}