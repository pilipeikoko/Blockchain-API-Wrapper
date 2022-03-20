using System.Collections.Generic;
using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class NftTokenHoldingResponse : Response
    {
        [JsonProperty("result")]
        public IEnumerable<NftTokenHolding> Result { get; set; }
    }
}
