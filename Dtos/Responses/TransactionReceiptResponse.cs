using BlockchainAnalysis.Models;
using Newtonsoft.Json;

namespace BlockchainAnalysis.Dtos.Responses
{
    internal class TransactionReceiptResponse : Response
    {
        [JsonProperty("result")]
        public TransactionReceipt Result { get; set; }
    }
}