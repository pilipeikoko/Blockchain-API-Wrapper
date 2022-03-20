using System.Collections.Generic;
using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class DailyNetworkUtilizationResponse : Response
    {
        [JsonProperty("result")]
        public IEnumerable<DailyNetworkUtilization> Result { get; set; }
    }
}
