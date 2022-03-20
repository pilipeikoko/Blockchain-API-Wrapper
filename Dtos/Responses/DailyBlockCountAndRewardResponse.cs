using System.Collections.Generic;
using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class DailyBlockCountAndRewardResponse : Response
    {
        [JsonProperty("result")] 
        public IEnumerable<DailyBlockCountAndReward> Result { get; set; }
    }
}