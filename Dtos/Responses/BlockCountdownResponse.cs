using BlockchainAnalysis.Models;
using Newtonsoft.Json;

namespace BlockchainAnalysis.Dtos.Responses
{
    internal class BlockCountdownResponse : Response
    {
        [JsonProperty("result")] 
        public BlockCountdown Result { get; set; }
    }
}