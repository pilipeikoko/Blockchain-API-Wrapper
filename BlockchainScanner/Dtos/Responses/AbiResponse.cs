using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class AbiResponse : Response
    {
        [JsonProperty("result")] 
        public string Result { get; set; }
    }
}