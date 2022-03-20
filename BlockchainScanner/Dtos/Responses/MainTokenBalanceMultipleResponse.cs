using System.Collections.Generic;
using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class MainTokenBalanceMultipleResponse : Response
    {
        [JsonProperty("result")] 
        public IEnumerable<MainTokenBalance> Balances { get; set; }
    }
}