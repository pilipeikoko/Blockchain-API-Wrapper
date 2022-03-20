using System.Collections.Generic;
using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class TokenHolderResponse : Response
    {
        [JsonProperty("result")]
        public IEnumerable<TokenHolder> Result { get; set; }
    }
}
