using System.Collections.Generic;
using BlockchainAnalysis.Models;
using Newtonsoft.Json;

namespace BlockchainAnalysis.Dtos.Responses
{
    internal class BlockResponse : Response
    {
        [JsonProperty("result")]
        public IEnumerable<Block> Result { get; set; }
    }
}