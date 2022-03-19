using System.Collections.Generic;
using BlockchainAnalysis.Models;
using Newtonsoft.Json;

namespace BlockchainAnalysis.Dtos.Responses
{
    internal class DailyBlockCountAndRewardResponse : Response
    {
        [JsonProperty("result")] 
        public IEnumerable<DailyBlockCountAndReward> Result { get; private set; }
    }
}