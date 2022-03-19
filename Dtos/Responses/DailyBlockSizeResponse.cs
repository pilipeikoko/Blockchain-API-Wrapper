using System.Collections.Generic;
using BlockchainAnalysis.Models;
using Newtonsoft.Json;

namespace BlockchainAnalysis.Dtos.Responses
{
    internal class DailyBlockSizeResponse : Response
    {
        [JsonProperty("result")] 
        public IEnumerable<DailyBlockSize> Result { get; private set; }
    }
}