using Newtonsoft.Json;

namespace BlockchainAnalysis.Dtos.Responses
{
    internal class AbiResponse : Response
    {
        [JsonProperty("result")] 
        public string Result { get; set; }
    }
}