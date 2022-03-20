using System.Collections.Generic;
using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class DailyBlockSizeResponse : Response
    {
        [JsonProperty("result")] 
        public IEnumerable<DailyBlockSize> Result { get; set; }
    }
}