using Newtonsoft.Json;

namespace BlockchainAnalysis.Dtos.Responses
{
    internal class BscTokenCirculatingSupplyResponse : Response
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }
}