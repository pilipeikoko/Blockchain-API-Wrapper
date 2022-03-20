using System.Collections.Generic;
using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class BlockResponse : Response
    {
        [JsonProperty("result")]
        public IEnumerable<Block> Result { get; set; }
    }
}