using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlockchainAnalysis.Models
{
    public class BlockReward
    {
        [JsonProperty("blockNumber")]
        public string BlockNumber { get; set; }

        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; }

        [JsonProperty("blockMiner")] 
        public string BlockMiner { get; set; }

        [JsonProperty("blockReward")]
        public string BlockRewardValue { get; set; }

        [JsonProperty("uncles")]
        public List<Uncle> Uncles { get; set; }

        [JsonProperty("uncleInclusionReward")]
        public string UncleInclusionReward { get; set; }
    }
}