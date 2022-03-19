using Newtonsoft.Json;

namespace BlockchainAnalysis.Dtos.Responses
{
    internal class BscBnbTotalSupplyResponse : Response
    {
        [JsonProperty("result")] 
        public string Result { get; set; }
    }
}