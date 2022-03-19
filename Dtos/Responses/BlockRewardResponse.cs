using BlockchainAnalysis.Models;
using Newtonsoft.Json;

namespace BlockchainAnalysis.Dtos.Responses
{
    internal class BlockRewardResponse : Response
    {
        [JsonProperty("result")]
        public BlockReward Result { get; set; }
    }
}