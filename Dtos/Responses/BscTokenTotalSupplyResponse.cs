using Newtonsoft.Json;

namespace BlockchainAnalysis.Dtos.Responses
{
    internal class BscTokenTotalSupplyResponse : Response
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }
}