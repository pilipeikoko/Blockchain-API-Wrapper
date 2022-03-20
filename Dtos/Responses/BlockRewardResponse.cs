using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class BlockRewardResponse : Response
    {
        [JsonProperty("result")]
        public BlockReward Result { get; set; }
    }
}