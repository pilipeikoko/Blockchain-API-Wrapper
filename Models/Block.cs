using Newtonsoft.Json;

namespace BlockchainAnalysis.Models
{
    public class Block
    {
        [JsonProperty("blockNumber")] 
        public string BlockNumber { get; set; }

        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; }

        [JsonProperty("blockReward")]
        public string BlockReward { get; set; }
    }
}