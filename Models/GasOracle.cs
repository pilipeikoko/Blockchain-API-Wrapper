using Newtonsoft.Json;

namespace BlockchainScanner.Models
{
    public class GasOracle
    {
        [JsonProperty("LastBlock")]
        public string LastBlock { get; set; }

        [JsonProperty("SafeGasPrice")]
        public string SafeGasPrice { get; set; }

        [JsonProperty("ProposeGasPrice")]
        public string ProposeGasPrice { get; set; }

        [JsonProperty("FastGasPrice")]
        public string FastGasPrice { get; set; }

        [JsonProperty("UsdPrice")]
        public string UsdPrice { get; set; }
    }
}
