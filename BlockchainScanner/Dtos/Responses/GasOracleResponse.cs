using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class GasOracleResponse : Response
    {
        [JsonProperty("result")]
        public GasOracle Result { get; set; }
    }
}
