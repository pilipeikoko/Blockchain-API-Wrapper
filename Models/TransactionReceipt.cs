using Newtonsoft.Json;

namespace BlockchainAnalysis.Models
{
    internal class TransactionReceipt
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }
}