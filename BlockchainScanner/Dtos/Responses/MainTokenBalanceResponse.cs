using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class MainTokenBalanceResponse : Response
    {
        [JsonProperty("result")] 
        public string Result { get; set; }
    }
}