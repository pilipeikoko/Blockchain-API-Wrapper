using Newtonsoft.Json;

namespace BscScanner.Dtos {
    internal class MainTokenBalanceResponse : Response {       

        [JsonProperty("result")]
        public string Result { get; private set; }
    }
}