using System.Collections.Generic;
using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class NftInventoryItemResponse : Response
    {
        [JsonProperty("result")]
        public IEnumerable<NftInventoryItem> Result { get; set; }
    }
}
