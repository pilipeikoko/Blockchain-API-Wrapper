using System.Collections.Generic;
using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class GasLimitResponse : Response
    {
        [JsonProperty("result")]
        public IEnumerable<GasLimit> Result { get; set; }
    }
}
