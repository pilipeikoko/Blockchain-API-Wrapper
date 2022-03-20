using System.Collections.Generic;
using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class DailyPriceItemResponse : Response
    {
        [JsonProperty("result")]
        public IEnumerable<DailyPriceItem> Result { get; set; }
    }
}
