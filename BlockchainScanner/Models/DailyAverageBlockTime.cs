using Newtonsoft.Json;

namespace BlockchainScanner.Models
{
    public class DailyAverageBlockTime
    {
        [JsonProperty("UTCDate")] 
        public string UTCDate { get; set; }

        [JsonProperty("unixTimeStamp")] 
        public int UnixTimeStamp { get; set; }

        [JsonProperty("blockTime_sec")] 
        public string BlockSizeInSeconds { get; set; }
    }
}