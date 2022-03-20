using System.Collections.Generic;
using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class TokenInformationResponse : Response
    {
        [JsonProperty("result")]
        public IEnumerable<TokenInformation> Result { get; set; }
    }
}
