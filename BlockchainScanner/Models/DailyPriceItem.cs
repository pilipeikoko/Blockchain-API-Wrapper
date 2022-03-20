using Newtonsoft.Json;

namespace BlockchainScanner.Models
{
    public class DailyPriceItem 
    {
        [JsonProperty("UTCDate")]
        public string UTCDate { get; set; }

        [JsonProperty("unixTimeStamp")]
        public int UnixTimeStamp { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
