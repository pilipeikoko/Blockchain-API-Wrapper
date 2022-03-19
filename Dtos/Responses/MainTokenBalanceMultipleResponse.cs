using System.Collections.Generic;
using BlockchainAnalysis.Models;
using Newtonsoft.Json;

namespace BlockchainAnalysis.Dtos.Responses
{
    internal class MainTokenBalanceMultipleResponse : Response
    {
        [JsonProperty("result")] 
        public List<MainTokenBalance> Balances { get; set; }
    }
}