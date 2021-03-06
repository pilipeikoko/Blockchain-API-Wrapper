using System.Collections.Generic;
using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class SourceCodeResponse : Response
    {
        [JsonProperty("result")] 
        public IEnumerable<Contract> Result { get; set; }
    }
}