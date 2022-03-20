using System.Collections.Generic;
using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class DailyAverageBlockTimeResponse : Response
    {
        [JsonProperty("result")] 
        public IEnumerable<DailyAverageBlockTime> Result { get; set; }
    }
}