using Newtonsoft.Json;

namespace BlockchainScanner.Models
{
    public class TokenHolding
    {
        [JsonProperty("TokenAddress")]
        public string TokenAddress { get; set; }

        [JsonProperty("TokenName")]
        public string TokenName { get; set; }

        [JsonProperty("TokenSymbol")]
        public string TokenSymbol { get; set; }

        [JsonProperty("TokenQuantity")]
        public string TokenQuantity { get; set; }

        [JsonProperty("TokenDivisor")] 
        public string TokenDivisor { get; set; } = string.Empty;
    }
}
