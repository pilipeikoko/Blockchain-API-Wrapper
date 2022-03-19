using System.Collections.Generic;
using BlockchainAnalysis.Models;
using Newtonsoft.Json;

namespace BlockchainAnalysis.Dtos.Responses
{
    internal class DailyBlockRewardResponse : Response
    {
        [JsonProperty("result")] 
        public IEnumerable<DailyBlockReward> Result { get; set; }
    }
}
