using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class TransactionReceiptResponse : Response
    {
        [JsonProperty("result")]
        public TransactionReceipt Result { get; set; }
    }
}