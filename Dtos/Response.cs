using BscScanner.Data;
using Newtonsoft.Json;

namespace BscScanner.Dtos
{
    internal abstract class Response
    {
        [JsonProperty("status")]
        public string Status { get; private set; }

        [JsonProperty("message")] 
        public string Message { get; private set; }
    }
}
