namespace BlockchainScanner.Chain.Configs
{
    public class BscConfig : BlockchainConfig
    {
        protected internal override string ApiUrl => "https://api.bscscan.com/api";
        protected internal override string ApiKey { get; internal set; }

        public BscConfig(string apiKey) : base(apiKey)
        {

        }
    }
}
