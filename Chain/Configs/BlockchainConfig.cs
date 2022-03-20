namespace BlockchainScanner.Chain.Configs
{
    public abstract class BlockchainConfig
    {
        protected internal abstract string ApiUrl { get; }
        protected internal abstract string ApiKey { get; internal set; }

        public BlockchainConfig(string apiKey)
        {
            ApiKey = apiKey;
        }
    }
}
