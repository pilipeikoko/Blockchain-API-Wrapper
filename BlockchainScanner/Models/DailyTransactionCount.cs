using Newtonsoft.Json;

namespace BlockchainScanner.Models
{
    public class DailyTransactionCount
    {
        [JsonProperty("UTCDate")]
        public string UTCDate { get; set; }

        [JsonProperty("unixTimeStamp")]
        public int UnixTimeStamp { get; set; }

        [JsonProperty("transactionCount")]
        public int TransactionCount { get; set; }
    }
}
