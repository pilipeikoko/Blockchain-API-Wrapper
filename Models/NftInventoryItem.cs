using Newtonsoft.Json;

namespace BlockchainScanner.Models
{
    public class NftInventoryItem
    {
        [JsonProperty("TokenAddress")]
        public string TokenAddress { get; set; }

        [JsonProperty("TokenId")]
        public string TokenId { get; set; }
    }
}
