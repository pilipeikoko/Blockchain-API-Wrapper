using System.Collections.Generic;
using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class GasUsedResponse : Response
    {
        [JsonProperty("result")]
        public IEnumerable<GasUsed> Result { get; set; }
    }
}
