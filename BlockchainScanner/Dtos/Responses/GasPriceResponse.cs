using System.Collections.Generic;
using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class GasPriceResponse : Response
    {
        [JsonProperty("result")]
        public IEnumerable<GasPrice> Result { get; set; }
    }
}
