using Newtonsoft.Json;

namespace BlockchainScanner.Models
{
    public class DailyNewAddressCount
    {
        [JsonProperty("UTCDate")]
        public string UTCDate { get; set; }

        [JsonProperty("unixTimeStamp")]
        public int UnixTimeStamp { get; set; }

        [JsonProperty("newAddressCount")]
        public int NewAddressCount { get; set; }
    }
}
