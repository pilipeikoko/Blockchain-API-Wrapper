using System.Collections.Generic;
using BlockchainScanner.Models;
using Newtonsoft.Json;

namespace BlockchainScanner.Dtos.Responses
{
    internal class ValidatorResponse : Response
    {
        [JsonProperty("result")]
        public IEnumerable<Validator> Result { get; set; }
    }
}