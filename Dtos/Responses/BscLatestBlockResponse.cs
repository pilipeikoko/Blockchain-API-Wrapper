using Newtonsoft.Json;

namespace BlockchainAnalysis.Dtos.Responses
{
    internal class BscLatestBlockResponse : Response
    {
        [JsonProperty("jsonrpc")]
        public string JsonRpc { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("result")] 
        public string Result { get; set; }
    }
}