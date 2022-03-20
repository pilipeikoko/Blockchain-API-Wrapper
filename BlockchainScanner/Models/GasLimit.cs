using Newtonsoft.Json;

namespace BlockchainScanner.Models
{
    public class GasLimit
    {
        [JsonProperty("UTCDate")]
        public string UTCDate { get; set; }

        [JsonProperty("unixTimeStamp")]
        public string UnixTimeStamp { get; set; }

        [JsonProperty("gasLimit")]
        public string GasLimitValue { get; set; }
    }
}
