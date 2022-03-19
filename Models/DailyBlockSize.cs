using Newtonsoft.Json;

namespace BlockchainAnalysis.Models
{
    public class DailyBlockSize
    {
        [JsonProperty("UTCDate")] 
        public string UTCDate { get; set; }

        [JsonProperty("unixTimeStamp")]
        public int UnixTimeStamp { get; set; }

        [JsonProperty("blockSize_bytes")]
        public int BlockSizeInBytes { get; set; }
    }
}
