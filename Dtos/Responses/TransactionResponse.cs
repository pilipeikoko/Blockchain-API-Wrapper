using System.Collections.Generic;
using BlockchainAnalysis.Models;
using Newtonsoft.Json;

namespace BlockchainAnalysis.Dtos.Responses
{
    internal class TransactionResponse : Response
    {
        [JsonProperty("result")]
        public List<Transaction> Result { get; set; }
    }
}