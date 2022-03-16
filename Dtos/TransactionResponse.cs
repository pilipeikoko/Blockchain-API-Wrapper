using System.Collections.Generic;
using Newtonsoft.Json;

namespace BscScanner.Data {
    internal class TransactionResponse : BscResult {
        
        [JsonProperty("result")] public List<Transaction> Result { get; private set; }
    }
}