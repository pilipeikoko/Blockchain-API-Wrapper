using Newtonsoft.Json;

namespace BlockchainAnalysis.Dtos.Responses
{
    internal class BlockByTimeResponse : Response
    {
        [JsonProperty("result")] 
        public string Result { get; set; }
    }
}