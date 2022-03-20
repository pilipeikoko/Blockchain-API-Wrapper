using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class TokenPriceResponse : Response
    {
        [JsonProperty("result")]
        public MainTokenPrice Result { get; set; }
    }
}