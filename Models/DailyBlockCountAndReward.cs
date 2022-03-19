using Newtonsoft.Json;

namespace BlockchainAnalysis.Models
{
    public class DailyBlockCountAndReward
    {
        [JsonProperty("UTCDate")]
        public string UTCDate { get; set; }

        [JsonProperty("unixTimeStamp")]
        public int UnixTimeStamp { get; set; }

        [JsonProperty("blockCount")]
        public int BlockCount { get; set; }

        [JsonProperty("blockRewards_Eth")]
        public int BlockRewards { get; set; }
    }
}
