using BlockchainScanner.Utils;
using Newtonsoft.Json;

namespace BlockchainScanner.Models
{
    public class MainTokenBalance
    {
        private double _balance;

        [JsonProperty("account")] public string Account { get; set; }

        [JsonProperty("balance")]
        public double Balance
        {
            get => _balance;
            set => _balance = WeiToMainTokenConverter.Convert(value);
        }
    }
}