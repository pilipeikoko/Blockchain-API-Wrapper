using Newtonsoft.Json;

namespace BlockchainScanner.Models
{
    public class DailyTransactionFee
    {
        [JsonProperty("UTCDate")]
        public string UTCDate { get; set; }

        [JsonProperty("unixTimeStamp")]
        public int UnixTimeStamp { get; set; }

        [JsonProperty("transactionFee_Eth")]
        public string TransactionFee { get; set; }
    }
}
