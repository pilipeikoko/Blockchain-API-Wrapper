using Newtonsoft.Json;

namespace BlockchainAnalysis.Dtos.Responses
{
    internal class BscBalanceSingleResponse : Response
    {
        [JsonProperty("result")] 
        public string Result { get; set; }
    }
}