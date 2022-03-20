using Newtonsoft.Json;

namespace BlockchainScanner.Models
{
    internal class TransactionReceipt
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }
}