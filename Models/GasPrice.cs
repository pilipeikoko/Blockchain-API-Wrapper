using Newtonsoft.Json;

namespace BlockchainScanner.Models
{
    public class GasPrice
    {
        [JsonProperty("UTCDate")]
        public string UTCDate { get; set; }

        [JsonProperty("unixTimeStamp")]
        public string UnixTimeStamp { get; set; }

        [JsonProperty("maxGasPrice_Wei")]
        public string MinGasPrice { get; set; }

        [JsonProperty("minGasPrice_Wei")]
        public string MaxGasPrice { get; set; }

        [JsonProperty("avgGasPrice_Wei")]
        public string AverageGasPrice { get; set; }
    }
}
