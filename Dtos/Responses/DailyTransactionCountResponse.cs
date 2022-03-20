using System.Collections.Generic;
using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class DailyTransactionCountResponse : Response
    {
        [JsonProperty("result")]
        public IEnumerable<DailyTransactionCount> Result { get; set; }
    }
}
