using Newtonsoft.Json;

namespace BlockchainScanner.Models
{
    public class TokenHolder
    {
        [JsonProperty("TokenHolderAddress")]
        public string TokenHolderAddress { get; set; }

        [JsonProperty("TokenHolderQuantity")]
        public string TokenHolderQuantity { get; set; }
    }
}
