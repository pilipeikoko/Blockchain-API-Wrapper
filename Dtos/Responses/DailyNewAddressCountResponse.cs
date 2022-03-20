using System.Collections.Generic;
using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class DailyNewAddressCountResponse : Response
    {
        [JsonProperty("result")]
        public IEnumerable<DailyNewAddressCount> Result { get; set; }
    }
}
