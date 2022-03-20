using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class BlockByTimeResponse : Response
    {
        [JsonProperty("result")] 
        public string Result { get; set; }
    }
}