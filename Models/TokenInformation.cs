using Newtonsoft.Json;

namespace BlockchainScanner.Models
{
    public class TokenInformation
    {
        [JsonProperty("contractAddress")]
        public string ContractAddress { get; set; }

        [JsonProperty("tokenName")]
        public string TokenName { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("divisor")]
        public string Divisor { get; set; }

        [JsonProperty("tokenType")]
        public string TokenType { get; set; }

        [JsonProperty("totalSupply")]
        public string TotalSupply { get; set; }

        [JsonProperty("blueCheckmark")]
        public string BlueCheckmark { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("blog")]
        public string Blog { get; set; }

        [JsonProperty("reddit")]
        public string Reddit { get; set; }

        [JsonProperty("slack")]
        public string Slack { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("bitcointalk")]
        public string BitcoinTalk { get; set; }

        [JsonProperty("github")]
        public string Github { get; set; }

        [JsonProperty("telegram")]
        public string Telegram { get; set; }

        [JsonProperty("wechat")]
        public string WeChat { get; set; }

        [JsonProperty("linkedin")]
        public string LinkedIn { get; set; }

        [JsonProperty("discord")]
        public string Discord { get; set; }

        [JsonProperty("whitepaper")]
        public string WhitePaper { get; set; }

        [JsonProperty("tokenPriceUSD")]
        public string TokenPriceUsd { get; set; }


    }
}
