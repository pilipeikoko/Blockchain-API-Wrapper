using System.Collections.Generic;
using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class DailyTransactionFeeResponse : Response
    {
        [JsonProperty("result")]
        public IEnumerable<DailyTransactionFee> Result { get; set; }
    }
}
