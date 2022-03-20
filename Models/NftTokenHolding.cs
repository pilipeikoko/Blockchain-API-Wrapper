using Newtonsoft.Json;

namespace BlockchainScanner.Models
{
    public class NftTokenHolding 
    {
        [JsonProperty("TokenAddress")]
        public string TokenAddress { get; set; }

        [JsonProperty("TokenName")]
        public string TokenName { get; set; }

        [JsonProperty("TokenSymbol")]
        public string TokenSymbol { get; set; }

        [JsonProperty("TokenQuantity")]
        public string TokenQuantity { get; set; }
    }
}
