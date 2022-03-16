using Newtonsoft.Json;

namespace BscScanner.Data
{
    public class MainTokenBalance {
        [JsonProperty("account")] public string Account { get; set; }
        [JsonProperty("balance")] public float Balance { get; set; }
    }
}
