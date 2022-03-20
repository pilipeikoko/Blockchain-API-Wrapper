using System.Collections.Generic;
using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class DailyBlockRewardResponse : Response
    {
        [JsonProperty("result")] 
        public IEnumerable<DailyBlockReward> Result { get; set; }
    }
}
