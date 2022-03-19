using BlockchainAnalysis.Models;
using Newtonsoft.Json;

namespace BlockchainAnalysis.Dtos.Responses
{
    internal class BscBnbLastPriceResponse : Response
    {
        [JsonProperty("result")]
        public MainTokenPrice Result { get; set; }
    }
}