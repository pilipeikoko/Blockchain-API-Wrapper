using System.Collections.Generic;
using BlockchainAnalysis.Models;
using Newtonsoft.Json;

namespace BlockchainAnalysis.Dtos.Responses
{
    internal class BscValidatorResponse : Response
    {
        [JsonProperty("result")]
        public IEnumerable<Validator> Result { get; set; }
    }
}