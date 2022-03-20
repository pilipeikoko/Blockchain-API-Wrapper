using System.Collections.Generic;
using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class TransactionResponse : Response
    {
        [JsonProperty("result")]
        public List<Transaction> Result { get; set; }
    }
}