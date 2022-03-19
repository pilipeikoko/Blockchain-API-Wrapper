using Newtonsoft.Json;

namespace BlockchainAnalysis.Dtos.Responses
{
    internal class MainTokenBalanceResponse : Response
    {
        [JsonProperty("result")] 
        public string Result { get; set; }
    }
}