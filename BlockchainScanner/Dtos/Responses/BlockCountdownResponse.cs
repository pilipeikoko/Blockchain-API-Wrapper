using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class BlockCountdownResponse : Response
    {
        [JsonProperty("result")] 
        public BlockCountdown Result { get; set; }
    }
}