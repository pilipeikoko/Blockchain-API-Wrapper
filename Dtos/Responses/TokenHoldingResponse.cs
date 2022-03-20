using System.Collections.Generic;
using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class TokenHoldingResponse : Response
    {
        [JsonProperty("result")]
        public IEnumerable<TokenHolding> Result { get; set; }
    }
}
