using Newtonsoft.Json;

namespace BlockchainScanner.Models
{
    public class DailyNetworkUtilization
    {
        [JsonProperty("UTCDate")]
        public string UTCDate { get; set; }

        [JsonProperty("unixTimeStamp")]
        public int UnixTimeStamp { get; set; }

        [JsonProperty("networkUtilization")]
        public string NewAddressCount { get; set; }
    }
}
