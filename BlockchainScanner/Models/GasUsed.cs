using Newtonsoft.Json;

namespace BlockchainScanner.Models
{
    public class GasUsed
    {
        [JsonProperty("UTCDate")]
        public string UTCDate { get; set; }

        [JsonProperty("unixTimeStamp")]
        public string UnixTimeStamp { get; set; }

        [JsonProperty("gasUsed")]
        public string GasUsedValue { get; set; }
    }
}
