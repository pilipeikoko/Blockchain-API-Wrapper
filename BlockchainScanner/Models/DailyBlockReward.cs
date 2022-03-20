using Newtonsoft.Json;

namespace BlockchainScanner.Models
{
    public class DailyBlockReward
    {
        [JsonProperty("UTCDate")]
        public string UTCDate { get; set; }

        [JsonProperty("unixTimeStamp")]
        public int UnixTimeStamp { get; set; }

        [JsonProperty("blockRewards_Eth")]
        public int BlockRewards { get; set; }
    }
}
