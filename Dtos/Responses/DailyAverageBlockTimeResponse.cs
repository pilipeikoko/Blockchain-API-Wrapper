﻿using System.Collections.Generic;
using BlockchainAnalysis.Models;
using Newtonsoft.Json;

namespace BlockchainAnalysis.Dtos.Responses
{
    internal class DailyAverageBlockTimeResponse : Response
    {
        [JsonProperty("result")] 
        public IEnumerable<DailyAverageBlockTime> Result { get; set; }
    }
}